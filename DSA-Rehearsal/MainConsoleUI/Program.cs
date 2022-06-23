using System;

namespace MainConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            char a;
            int b;

            Console.WriteLine("Enter a letter between a-z");
            a = Convert.ToChar(Console.ReadLine());
            b = (int)a;

            if(b >= 97 && b <= 122)
            {
                b = b - 32;
                a = (char)b;
                Console.WriteLine("In Uppercase letter: " + a);
            }
            else
            {
                Console.WriteLine("You enter a wrong letter. Letters need to be between a-z");
            }
            Console.ReadLine();
        }
    }
}

//Write a program that converts 1 lowercase letter ("a" - "z") to its corresponding uppercase letter ("A" - "Z").
//For example if the user enters "c" then the program will show "C" on the screen.