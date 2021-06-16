﻿using HotelAppLibray.Databases;
using HotelAppLibray.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HotelAppLibray.Data
{
	public class SqliteData : IDatabaseData
	{
		private const string connectionStringName = "SQLiteDb";
		private readonly ISqliteDataAccess db;

		public SqliteData(ISqliteDataAccess db)
		{
			this.db = db;
		}

		public void BookGuest(string firstName, string lastName, DateTime startDate, DateTime endDate, int roomTypeId)
		{
			string sql = @"select 1 from Guests where FirstName = @firstName and LastName = @lastName";
			int results = db.LoadData<dynamic, dynamic>(sql, new { firstName, lastName }, connectionStringName).Count();

			if (results ==0)
			{
				sql = @"insert into Guests (FirstName, LastName)
							values (@firstName, @lastName);";

				db.SaveData(sql, new { firstName, lastName }, connectionStringName);
			}

			sql = @"select [Id], [FirstName], [LastName]
						from Guests
						where FirstName = @firstName and LastName = @lastName LIMIT 1;";

			GuestModel guest = db.LoadData<GuestModel, dynamic>(sql,
																 new { firstName, lastName },
																 connectionStringName).First();

			RoomTypeModel roomType = db.LoadData<RoomTypeModel, dynamic>("select * from RoomTypes where Id = @Id",
																		  new { Id = roomTypeId },
																		  connectionStringName).First();

			TimeSpan timeStaying = endDate.Date.Subtract(startDate.Date);

			sql = @"select r.*
				from Rooms r
				inner join RoomTypes t on t.id = r.RoomTypeId
				where r.RoomTypeId = @roomTypeId
				and r.Id not in (
				select b.RoomId
				from Bookings b
				where	(@startDate < b.StartDate and @endDate > b.EndDate)
					or (b.StartDate <= @endDate and @endDate < b.EndDate)
					or (b.StartDate <= @startDate and @startDate < b.EndDate)
					);";

			List<RoomModel> avalaibleRooms = db.LoadData<RoomModel, dynamic>(sql,
																			  new { startDate, endDate, roomTypeId },
																			  connectionStringName);

			sql = @"insert into Bookings (RoomId, GuestId, StartDate, EndDate, TotalCost)
					values (@roomId, @guestId, @startDate, @endDate, @totalCost);";

			db.SaveData(sql,
						 new
						 {
							 roomId = avalaibleRooms.First().Id,
							 guestId = guest.Id,
							 startDate = startDate,
							 endDate = startDate,
							 totalCost = timeStaying.Days * roomType.Price
						 },
						 connectionStringName);
		}

		public void CheckinGuest(int bookingId)
		{
			string sql = @"update dbo.Bookings
						set CheckedIn = 1
						where Id = @Id;";
			db.SaveData(sql, new { Id = bookingId }, connectionStringName);
		}

		public List<RoomTypeModel> GetAvailableRooms(DateTime startDate, DateTime endDate)
		{
			string sqlite = @"select t.Id, t.Title, t.Description, t.Price
							from Rooms r
							inner join RoomTypes t on t.id = r.RoomTypeId
							where r.Id not in (
							select b.RoomId
							from Bookings b
							where	(@startDate < b.StartDate and @endDate > b.EndDate)
								or (b.StartDate <= @endDate and @endDate < b.EndDate)
								or (b.StartDate <= @startDate and @startDate < b.EndDate)
							)
							group by t.Id, t.Title, t.Description, t.Price";

			var output = db.LoadData<RoomTypeModel, dynamic>(sqlite,
									 new { startDate, endDate },
									 connectionStringName);

			output.ForEach(x => x.Price /= 100);
			return output;
		}

		public RoomTypeModel GetRoomTypeById(int id)
		{
			string sql = @"select [Id], [Title], [Description], [Price]
						from RoomTypes
						where Id = @id";

			return db.LoadData<RoomTypeModel, dynamic>(sql,
												 new { id },
												 connectionStringName).FirstOrDefault();
		}

		//Some of this code can be refactored
		public List<BookingFullModel> SearchBookings(string lastName)
		{
			string sql = @"select [b].[Id], [b].[RoomId], [b].[GuestId], [b].[StartDate], [b].[EndDate], 
							[b].[CheckedIn], [b].[TotalCost], [g].[FirstName], [g].[LastName], 
							[r].[RoomNumber], [r].[RoomTypeId], [rt].[Title], [rt].[Description], 
							[rt].[Price]
						from Bookings b
						inner join Guests g on b.GuestId = g.Id
						inner join Rooms r on b.RoomId = r.Id
						inner join RoomTypes rt on r.RoomTypeId = rt.Id
						where b.StartDate = @startDate and g.LastName = @lastName;";

			var output = db.LoadData<BookingFullModel, dynamic>(sql,
										new { lastName, startDate = DateTime.Now.Date },
										connectionStringName);


			output.ForEach(x =>
			{                
				x.Price /= 100; 
				x.TotalCost /= 100;
			});

			return output;
		}
	}
}
