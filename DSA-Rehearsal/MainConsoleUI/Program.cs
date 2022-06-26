﻿using System;
using System.Net.WebSockets;

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
                    ShowPrimeNumbers();
                    //DuplicateCount();
                    //PrintASCIIValues();
                    //PrintOutput();
                    //Iteration();
                    //IdentityMatrix();
                    //LeapYear();
                }
                catch (Exception e)
                {
                    Console.WriteLine("Jean found an error: \n" + e.Message);
                }
                Console.ReadLine();
            }
        }


        public static void ShowPrimeNumbers()
        {
            int[] array = new int[10];
            int count = 0, i, j, k = 2;
            for (i = 0; i < 10; i++)
            {
                Console.WriteLine("Enter the " + (i+1) + "st value: ");
                array[i] = Convert.ToInt32(Console.ReadLine());
            }
            for (j = 0; j < 10; j++)
            {
                for (k = 2; j < array[count]; k++)
                {
                    if (array[count] % k == 0)
                    {
                        goto to;
                    }
                }
            to: if (k == array[count])
                {
                    Console.WriteLine("Entered value: " + array[count] + "is prime number");
                }
                if (array[count] == 0 || array[count] == 1)
                {
                    Console.WriteLine("Entered value : " + array[count] + "is not prime number");
                }
                count++;
            }
        }

        public static void DuplicateCount()
        {
            int space = 7;
            int num = 1;
            for (int x = 1; x < 5; x++)
            {
                for (int y = 1; y <= space; y++)
                {
                    Console.Write(" ");
                }
                space = space - 2;
                for (int z = 1; z <= x; z++)
                {
                    Console.Write(num);
                    Console.Write(" ");
                    num++;
                }
                Console.WriteLine("\n");
            }
            Console.ReadLine();
        }

        public static void PrintASCIIValues()
        {
            //Write a program to print all the ASCII values and their equivalent characters using a while loop.
            //The ASCII values vary from 0 to 255.
            char ch;
            int x = 0;
            while (x <= 255)
            //can be done using do while loop.
            {
                Console.Write(x);
                Console.Write(" ");

                ch = (char)x;
                Console.WriteLine(ch);
                x++;
            }
            Console.ReadLine();
        }

        public static void PrintOutput()
        {
            //Write a program using a loop that prints the following output.
            //1 2 2 3 3 3 4 4 4 4 5 5 5 5 5 6 6 6 6 6 6. . .nth iteration.
            int value;
            Console.WriteLine("Enter a value: ");

            value = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\n");

            for (int x = 0; x <= value; x++)
            {
                for (int y = 1; y <= x; y++)
                {
                    Console.Write(x);
                }
                Console.Write(" ");
            }
            Console.ReadLine();
        }

        public static void Iteration()
        {
            //Write a program using a for loop that prints the following series.
            //1 2 4 8 16 21 64 128 …nth iteration.
            int value;
            double result;
            Console.WriteLine("Enter some value");

            value = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Here are the iteration: ");

            for (int x = 0; x <= value; x++)
            {
                result = Math.Pow(2, x);
                Console.Write(result);
                Console.Write(" ");
            }
            Console.ReadKey();
        }

        public static void IdentityMatrix()
        {
            //Write a program that prints an identity matrix using a for loop,
            //in other words takes a value n from the user and shows the identity table of size n * n.
            int size;
            Console.WriteLine("Enter the size of the identity matrix");
            size = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Identity Matrix");
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    if (i == j)
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

        public static void LeapYear()
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