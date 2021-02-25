using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HotelAppLibray.Data;
using HotelAppLibray.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace HotelApp.Web.Pages
{
    public class BookRoomModel : PageModel
    {
        private readonly IDatabaseData _db;

        [BindProperty(SupportsGet = true)]
        public int RoomTypeId { get; set; }

        [BindProperty(SupportsGet = true)]
        public DateTime StartDate { get; set; }

        [BindProperty(SupportsGet = true)]
        public DateTime EndDate { get; set; }

        [BindProperty]
        public String FirstName { get; set; }
        [BindProperty]
        public String LastName { get; set; }

        public RoomTypeModel RoomType { get; set; }

        public BookRoomModel(IDatabaseData db)
        {
            _db = db;
        }
        public void OnGet()
        {
            if (RoomTypeId > 0)
            {
                RoomType = _db.GetRoomTypeById(RoomTypeId);
            }
        }

        public IActionResult OnPost()
        {
            _db.BookGuest(FirstName, LastName, StartDate, EndDate, RoomTypeId);
            return RedirectToPage("/Index");
        }


    }
}
