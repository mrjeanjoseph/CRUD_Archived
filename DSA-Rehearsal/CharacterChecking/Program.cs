using System;

namespace CharacterChecking
{
    class Program
    {
        static void Main(string[] args)
        {
            char a;
            int b;
            Console.WriteLine("Enter a character:");

            a = Convert.ToChar(Console.ReadLine());
            b = (int)a;

            if (b >= 65 && b <= 90)
            {
                Console.WriteLine("Entered character is uppercase letter:");
            }

            if (b >= 97 && b <= 122)
            {
                Console.WriteLine("Entered character is small letter:");
            }

            if (b >= 48 && b <= 57)
            {
                Console.WriteLine("Entered character is a digit:");
            }

            if (b >= 0 && b <= 47 || b >= 58 && b <= 64 || b >= 91 && b <= 96 || b >= 123 && b <= 127)
            {
                //Needs to be reworked
                Console.WriteLine("Entered character is special character:");
            }

            Console.ReadLine();
        }
    }
}

//Write a program that takes a character from the user and determines
//whether the character entered is a capital letter,
//a small case letter, a digit or a special symbol.
//The following table shows the range of ASCII values for various characters.