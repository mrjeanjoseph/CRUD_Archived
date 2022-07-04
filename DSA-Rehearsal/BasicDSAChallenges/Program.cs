﻿using System;
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

            //FindLongestWord();
            //Console.WriteLine(Within20or100(221));
            //Console.WriteLine(ReturnTrueIf20(5,15));
            //Console.WriteLine(ReturnDoubleAbsValues(10,7));           
            //Console.WriteLine(TripleSum(6,3));
            //Console.WriteLine(TripleSum(5,5));
            //PrintOddNumbers();
            //ComputeFirst500PrimeNumbers();

            SumOfItsDigits(56);

        }

        private static void SumOfItsDigits(int d) {
            //compute the sum of the digits of an integer.
            int sum = 0;
            while(d != 0) {
                sum += d % 10;
                d/= 10;
            }
            Console.WriteLine($"The sum of the digits is: {sum}");
        }

        private static void ComputeFirst500PrimeNumbers() {
            //Compute the sum of the first 500 prime numbers.
            long sum = 0;
            int ctr = 0, n = 2;
            while (ctr < 500) {
                if (isPrime(n)) {
                    sum += n;
                    ctr++;
                }
                n++;
            }
            Console.WriteLine(sum.ToString());
        }

        private static bool isPrime(int n) {
            //Checking if value is prime
            int x = (int)Math.Floor(Math.Sqrt(n));

            if (n == 1) return false;
            if(n == 2) return true;

            for(int i = 2; i <= x; i++) {
                if(n% i == 0) return false;
            }
            return true;
        }

        private static void PrintOddNumbers() {
            //Print odd numbers from 1 to 99 - one number per line
            for (int i = 1; i < 100; i++) {
                if (i % 2 != 0) {

                    Console.WriteLine(i);
                }
            }
        }

        public static void FindLongestWord() {
            //Find the longest word in a string
            string str = "finding the longest word in a complicated string.";

            string[] words = str.Split(new[] { " " }, StringSplitOptions.None);
            string word = "";
            int counter = 0;
            foreach (string s in words) {
                if (s.Length > counter) {
                    word = s;
                    counter = s.Length;
                }
            }
            Console.WriteLine(word);
        }

        public static bool Within20or100(int x) {
            //Check if an given integer is within 20 of 100 or 200
            if (Math.Abs(x - 100) <= 20 || Math.Abs(x - 200) <= 20)
                return true;
            return false;

        }

        public static bool ReturnTrueIf20(int x, int y) {
            //Check the sum of the two given integers and return true if one of the integer is 20 or if their sum is 20.
            return x == 20 || y == 20 || (x + y == 20);
        }

        public static int ReturnDoubleAbsValues(int x, int y) {
            //Get the absolute value of the difference between two given numbers. Return double the absolute value of the difference if the first number is greater than second number.
            if (x > y)
                return (x - y) * 2;
            else
                return (x - y);

        }

        public static int TripleSum(int x, int y) {
            //Compute the sum of two given integers, if two values are equal then return the triple of their sum
            if (x == y)
                return (x + y) * 3;
            else
                return (x + y);

        }
    }
}
