using System;
using System.Data.SqlClient;

namespace ConsoleDB_Rehearse {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Hello World!");
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
