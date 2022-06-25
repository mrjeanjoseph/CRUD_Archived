using System;

namespace MainConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                
                try
                {
                    LeapYear();
                }
                catch (Exception e)
                {
                    Console.WriteLine("Jean found an error: \n" + e.Message);
                }
                Console.ReadLine();
            }


        }

        static void LeapYear()
        {
            int year;
            string response;
            Console.WriteLine("Enter a Year:");
            year = Convert.ToInt32(Console.ReadLine());
            if (year % 4 == 0)
            {
                response = "Year is leap";
            }
            else
            {
                response = "Not a leap year";
            }
            //response = year % 4 == 0 ? "Year is leap year." : "Year is not a leap year.";
            Console.WriteLine(response);
        }
    }



}