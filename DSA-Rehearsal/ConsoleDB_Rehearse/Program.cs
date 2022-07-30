using System;
using System.Data.SqlClient;

namespace ConsoleDB_Rehearse {
    class Program {
        static void Main(string[] args) {
            ConnectToDB2();
            Console.ReadLine();
        }

        public static void ConnectToDB2() {
            string connString = @"Server=.\sqlexpress;Database=master;Trusted_Connection=True;";

            try {
                using SqlConnection conn = new SqlConnection(connString); 
                string query = @"SELECT @@VERSION";

                SqlCommand cmd = new SqlCommand(query, conn);
                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read()) {
                    while (reader.Read()) {
                        Console.WriteLine(reader.GetString(0));
                    }
                } else {
                    Console.WriteLine("No data Found...,");
                }
                reader.Close();

            } catch (Exception ex) {
                Console.WriteLine("An Error has occurred" + ex.Message);
            }
        }

        public static void GetData() {
            string defaultConn = "Server=.\\sqlexpress;Database=AdventureWorks2019;Trusted_Connection=True";
            SqlConnection connection = new SqlConnection(defaultConn);

            int count = 0;
            try {
                count++;
                using (connection) {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand("SELECT CONCAT(FirstName,' ',MiddleName,' ',LastName) [Full Name] FROM [Person].[Person]", connection)) {
                        using (SqlDataReader reader = command.ExecuteReader()) {
                            while (reader.Read()) {
                                for (int i = 0; i < reader.FieldCount; i++) {
                                    Console.WriteLine($"{reader.GetValue(i)}");
                                }
                            }
                        }
                    }
                }

            } catch (SqlException ex) {
                Console.WriteLine("An error occurred!");

            } finally {
                connection.Close();
                Console.WriteLine("Data base Connection Closed.");
            }
        }

        public static void InsertData() {
            SqlConnection MyConn = new SqlConnection("Server=.\\sqlexpress;Database=MyDb;Trusted_Connection=True");
            SqlCommand command = MyConn.CreateCommand();

            try {
                MyConn.Open();

                command.CommandText = "INSERT INTO tbl1 VALUES (03)" +
                                        "INSERT INTO tbl1 VALUES (08)" +
                                        "INSERT INTO tbl1 VALUES (17)";

                Console.WriteLine(command.CommandText);
                Console.WriteLine("Number of Rows Affected is: {0}", command.ExecuteNonQuery());

            } catch (SqlException ex) {
                Console.WriteLine("Error occurred!");

            } finally {
                MyConn.Close();
                Console.WriteLine("Data base Connection Closed.");
            }
        }

        public static void OriginalCode() {
            //SqlConnection MyConn = new SqlConnection("Server=.\\sqlexpress;Trusted_Connection=True");
            SqlConnection MyConn = new SqlConnection("Server=.\\sqlexpress;Database=MyDb;Trusted_Connection=True");
            //I am only using the server name, no database name
            SqlCommand command = MyConn.CreateCommand();

            try {
                MyConn.Open();

                //command.CommandText = "CREATE DATABASE MyDb";
                //Console.WriteLine(command.CommandText);
                //command.ExecuteNonQuery();

                //Console.WriteLine("Now switching");
                //MyConn.ChangeDatabase("MyDb"); // Here I am changing to the db object I need

                //command.CommandText = "CREATE TABLE tbl1 (COL1 integer)";
                //Console.WriteLine(command.CommandText);
                //Console.WriteLine("Number of Rows Affected is: {0}", command.ExecuteNonQuery());

                command.CommandText = "INSERT INTO tbl1 VALUES (03)" +
                                        "INSERT INTO tbl1 VALUES (08)" +
                                        "INSERT INTO tbl1 VALUES (17)";

                Console.WriteLine(command.CommandText);
                Console.WriteLine("Number of Rows Affected is: {0}", command.ExecuteNonQuery());

            } catch (SqlException ex) {

                //Console.WriteLine(ex.ToString());
                Console.WriteLine("Error occurred!");

            } finally {

                MyConn.Close();
                Console.WriteLine("Data base Connection Closed.");

            }
        }

    }
}
