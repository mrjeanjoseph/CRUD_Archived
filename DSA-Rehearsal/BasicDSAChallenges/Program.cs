using System;
using System.Threading;

namespace BasicDSAChallenges {
    class Program {
        static void Main(string[] args) {
            Console.Title = "Basic DSA Tutorials";

            while (true) {
                try {
                    reverseString2("Holy Macaroni");
                    //Console.WriteLine(reverseString("Louna"));
                    //remove_char("w3resource", 1);
                    //CelsiusConversion();
                    //DisplayFourTimes();

                } catch (Exception e) {

                    Console.WriteLine("Jean found an error: \n" + e.Message);

                } finally {

                    Console.WriteLine("\nPress any key to continue. \n\tProgram will restart.");
                    Console.ReadLine();
                    Console.Clear();
                }

            }

            #region Challenges
            //CheckAge();
            //ComplexCalcOne();
            //GetTheAverage();
            //MultiplicationTable();
            //MultipleOperation();
            //MultiplyThreeValues();
            //FlippingNumbers();
            #endregion

        }

        public static string reverseString(string s) {
            //return s.Length > 1
                //? s.Substring(s.Length - 1) + s.Substring(1, s.Length - 2) + s.Substring(0, 1) : s;

            if(s.Length > 1) 
               return s.Substring(s.Length - 1) + s.Substring(1, s.Length - 2) + s.Substring(0, 1);
            else
                return s;
        }

        public static void remove_char(string str, int n) {
            //15. Write a C# program remove specified a character from a non-empty string using index of a character.
            Console.WriteLine(str.Remove(n, 1));
        }

        public static void CelsiusConversion() {
            Console.WriteLine("Enter a numerical value: ");
            int celsius = int.Parse(Console.ReadLine());

            Console.WriteLine("Kelvin = {0}", celsius + 273);
            Console.WriteLine("Farenheit = {0}", celsius * 18 / 10 + 32);
        }
        
        public static void DisplayFourTimes() {
            int d;
            Console.WriteLine("Enter a digit: ");
            d = int.Parse(Console.ReadLine());

            Console.WriteLine($"{d} {d} {d} {d}");
            Console.WriteLine($"{d}{d}{d}{d}");
            Console.WriteLine($"{d} {d} {d} {d}");
            Console.WriteLine($"{d}{d}{d}{d}");
        }

        public static void CheckAge() {
            //Write a C# Sharp program that takes an age (for example 20) as input and prints something as "You look older than 20".
            int getAge;
            Console.WriteLine("Enter your age: ");
            getAge = int.Parse(Console.ReadLine());

            Console.WriteLine($"At {getAge}, you look younger than 20.");
        }

        public static void ComplexCalcOne() {
            //Write a C# Sharp program to that takes three numbers(x,y,z) as input and output (x+y)*z and x*y + y*z.
            int x, y, z, result1, result2;
            Console.WriteLine("Enter first Number: ");
            x = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter first Number: ");
            y = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter first Number: ");
            z = int.Parse(Console.ReadLine());

            result1 = (x + y) * z;
            result2 = (x * y) + (y * z);
            Console.WriteLine($"({x}+{y})*{z} = " + result1);
            Console.WriteLine($"({x}*{y}) + ({y}*{z}) = " + result2);

        }

        public static void GetTheAverage() {
            //Write a C# Sharp program that takes four numbers as input to calculate and print the average.
            double firstNum, secondNum, thirdNum, fourthNum;
            double result;

            Console.WriteLine("Enter the first number: ");
            firstNum = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter the second number: ");
            secondNum = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter the third number: ");
            thirdNum = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter the fourth number: ");
            fourthNum = double.Parse(Console.ReadLine());

            result = ((firstNum + secondNum + thirdNum + fourthNum) / 4);
            Console.WriteLine($"The average of {firstNum} + {secondNum} + {thirdNum} + {fourthNum} = {result}");
        }

        public static void MultiplicationTable() {
            //Write a C# Sharp program that takes a number as input and print its multiplication table
            int num;
            Console.WriteLine("Enter a number to be multiplied");
            num = int.Parse(Console.ReadLine());

            for (int i = 1; i < 4; i++) {
                Console.WriteLine($"{num} multiply by {i} = " + num * i);
            }
        }

        public static void MultipleOperation() {
            int firstNum, secondNum, result;

            Console.WriteLine("Enter First Number: ");
            firstNum = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter second Number: ");
            secondNum = int.Parse(Console.ReadLine());

            result = firstNum + secondNum;
            Console.WriteLine($"{firstNum} plus {secondNum} = " + result);

            result = firstNum - secondNum;
            Console.WriteLine($"{firstNum} minus {secondNum} = " + result);

            result = firstNum * secondNum;
            Console.WriteLine($"{firstNum} multiply by {secondNum} = " + result);

            result = firstNum / secondNum;
            Console.WriteLine($"{firstNum} divide {secondNum} = " + result);

            result = firstNum % secondNum;
            Console.WriteLine($" The remainder of {firstNum} % {secondNum} = " + result);
        }

        public static void MultiplyThreeValues() {
            Console.Title = "DSA Tutorials";

            int firstNum, secondNum, thirdNum, result;

            Console.WriteLine("Enter the first Number: ");
            firstNum = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the second Number: ");
            secondNum = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the third Number: ");
            thirdNum = int.Parse(Console.ReadLine());

            result = firstNum * secondNum * thirdNum;
            Console.WriteLine("The result is: {0}", result);

        }

        public static void FlippingNumbers() {
            int number1, number2, temp;

            Console.WriteLine("Enter the first number: ");
            number1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the second number: ");
            number2 = int.Parse(Console.ReadLine());

            temp = number1;
            number1 = number2;
            number2 = temp;

            Console.WriteLine("After swapping: ");
            Console.WriteLine("First Number: " + number1);
            Console.WriteLine("Second Number: " + number2);
        }
    }
}
