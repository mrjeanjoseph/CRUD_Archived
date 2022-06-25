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
                    IdentityMatrix();

                    //LeapYear();
                }
                catch (Exception e)
                {
                    Console.WriteLine("Jean found an error: \n" + e.Message);
                }
                Console.ReadLine();
            }


        }

        public static void IdentityMatrix()
        {
            int size;
            Console.WriteLine("Enter the size of the identity matrix");
            size = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Identity Matrix");
            for(int i = 0; i < size; i++)
            {
                for(int j = 0; j < size; j++)
                {
                    if(i == j)
                    {
                        Console.Write(1);
                    }
                    else
                    {
                        Console.Write(0);
                    }
                }
                Console.WriteLine("\n");
            }
            Console.ReadLine();
        }

        static void LeapYear()
        {
            //Instruction:
            //Write a program using conditional operators to determine whether a year entered through the keyboard is a leap year or not.

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
            //I can use a Ternary operation too
            //response = year % 4 == 0 ? "Year is leap year." : "Year is not a leap year.";
            Console.WriteLine(response);
        }
    }



}