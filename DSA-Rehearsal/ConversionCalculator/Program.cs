using System;

namespace ConversionCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            int value;
            char choice;
            double centimeter, kilometer, kilogram, liters;
            Console.WriteLine("Enter a digit value: ");
            value = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Press Any Of The Given Choices\n"+
                "\tI -> convert from inches to centimeters.\n"+
                "\tG -> convert from gallons to liters.\n"+
                "\tM -> convert from mile to kilometer.\n"+
                "\tP -> convert from pound to kilogram.\n");

            choice = Convert.ToChar(Console.ReadLine().ToUpper());

            switch (choice)
                //this needs to be reworked
            {
                case 'I':
                    centimeter = value / 0.3937;
                    Console.WriteLine("Inch to cm: " + centimeter);
                    break;
                    
                case 'G':
                    liters = value / 3.78;
                    Console.WriteLine("Gal to litters: " + liters);
                    break;
                    
                case 'M':
                    kilometer = value / 1.60;
                    Console.WriteLine("Miles to km: " + kilometer);
                    break;
                    
                case 'P':
                    kilogram = value / 0.453;
                    Console.WriteLine("Miles to km: " + kilogram);
                    break;

                default:
                    Console.WriteLine("You entered an invalid character. Please enter a valid char.");
                    break;
            }
            Console.ReadLine();
        }
    }
}

//Writing a program using a switch statement that takes one value from the user and asks about the type of conversion and then performs a conversion depending on the type of conversion. If user enters:

//I->convert from inches to centimeters.
//G->convert from gallons to liters.
//M->convert from mile to kilometer.
//P->convert from pound to kilogram.

//If the user enters any other character then show a proper message.