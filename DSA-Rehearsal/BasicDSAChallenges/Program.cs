using System;
using System.Threading;

namespace BasicDSAChallenges {
    class Program {
        static void Main(string[] args) {
            Console.Title = "Basic DSA Tutorials";

            while (true) {
                try {
                    runProgram();

                } catch (Exception e) {

                    Console.WriteLine("Jean found an error: \n" + e.Message);

                } finally {

                    Console.WriteLine("\nPress any key to continue. \n\tProgram will restart.");
                    Console.ReadLine();
                    Console.Clear();
                }
            }

        }

        public static void runProgram() {

            Console.WriteLine(ReturnDoubleAbsValues(10,7));           
            //Console.WriteLine(TripleSum(6,3));
            //Console.WriteLine(TripleSum(5,5));

        }

        public static int ReturnDoubleAbsValues(int x, int y) {
            // Write a C# program to get the absolute value of the difference between two given numbers. Return double the absolute value of the difference if the first number is greater than second number.
            if(x > y)
                return (x - y) * 2;
            else
                return (x - y);

        }

        public static int TripleSum(int x, int y) {
            if (x == y)
                return (x + y) * 3;
            else
                return (x + y);

        }
    }
}
