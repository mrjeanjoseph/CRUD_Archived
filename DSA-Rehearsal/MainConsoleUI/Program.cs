﻿using System;
using System.Net.WebSockets;

namespace MainConsoleUI {
    class Program {
        static void Main(string[] args) {

            Console.Title = "DSA Tutorials";

            while (true) {
                try {
                    GetTheAverage();
                    //MultiplicationTable();
                    //MultipleOperation();

                } catch (Exception e) {

                    Console.WriteLine("Jean found an error: \n" + e.Message);

                } finally {

                    Console.WriteLine("\nPress any key to continue. \n\tProgram will restart.");
                    Console.ReadLine();
                    Console.Clear();
                }

            }

            #region Challenges
            //MultiplyThreeValues();
            //FlippingNumbers();
            //PrintTriangleOne();
            //Fibonacci();
            //BinarySearch();
            //BubbleSorting();
            //SortASCOrder();
            //CountPrintExecution();
            //ShowPrimeNumbers();
            //DuplicateCount();
            //PrintASCIIValues();
            //PrintOutput();
            //Iteration();
            //IdentityMatrix();
            //LeapYear();
            #endregion

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

        public static void PrintTriangleOne() {
            //Use a for loop to print a triangle on the screen.
            for (int x = 0; x < 4; x++) {
                for (int y = 0; y <= x; y++) {
                    Console.Write("*");
                }
                Console.WriteLine("\n");
            }
            for (int x = 0; x <= 2; x++) {
                for (int y = 3; y > x; y--) {
                    Console.Write("*");
                }
                Console.WriteLine("\n");
            }
        }

        public static void Fibonacci() {
            //Write a program that prints the Fibonacci series using a loop.
            int num, next, first = 0, second = 1;
            Console.WriteLine("Enter the number of terms of fibonacci series you want to convert: ");
            num = Convert.ToInt32(Console.ReadLine());
            for (int x = 0; x < num; x++) {
                if (x <= 1) next = x;
                else {
                    next = first + second;
                    first = second;
                    second = next;
                }
                Console.Write(next);
                Console.Write(" ");
            }
        }

        public static void BinarySearch() {
            //takes n values in an array and then search for a value in the array using a binary search algorithm.
            int num, temp, first = 0, last, mid, found, count = 1;

            Console.WriteLine("Enter the numbers you want to enter: ");
            num = Convert.ToInt32(Console.ReadLine());

            int[] array = new int[num];
            for (int x = 0; x < num; x++) {
                Console.WriteLine("Enter value " + count);
                array[x] = Convert.ToInt32(Console.ReadLine());

                count++;
            }

            for (int x = 0; x < num; x++) {
                for (int y = 0; y < num - 1; y++) {
                    if (array[y] > array[y + 1]) {

                        temp = array[y];
                        array[y] = array[y + 1];
                        array[y + 1] = temp;

                    }
                }
            }

            Console.WriteLine("Enter the number you want to search for: ");
            found = Convert.ToInt32(Console.ReadLine());

            last = num - 1;
            mid = (first + last) / 2;

            //There's a bug here, find it
            while (first <= last) {
                if (array[mid] < found) first = mid + 1;
                else if (array[mid] == found) {
                    Console.WriteLine(found + " found at location " + mid);
                    break;
                } else last = mid - 1;
                mid = (first + last) / 2;
            }

            if (first > last) Console.WriteLine("Not Found: " + found + " is not present in the list");
        }

        public static void BubbleSorting() {
            //Takes n values from the user and sorts
            int num, temp;

            Console.WriteLine("Enter the numbers you want to enter: ");
            num = Convert.ToInt32(Console.ReadLine());

            int[] array = new int[num];
            for (int i = 0; i < num; i++) {
                Console.WriteLine("Enter " + i + " value");
                array[i] = Convert.ToInt32(Console.ReadLine());
            }

            for (int i = 0; i < num; i++) {
                //loop here first before sorting
                for (int j = 0; j < num - 1; j++) {
                    if (array[j] > array[j + 1]) {
                        temp = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = temp;
                    }
                }
            }

            Console.Clear();
            Console.WriteLine("In Ascending order using bubble sort: ");
            for (int i = 0; i < num; i++) {
                Console.WriteLine(array[i]);
            }
        }

        public static void SortASCOrder() {
            //Instruction: Takes nth values from user and then sorts them in ascending order.
            int num, temp;
            string nth = "";

            Console.Write("How many numerical values to sort? ");
            num = Convert.ToInt32(Console.ReadLine());

            int[] array = new int[num];

            for (int x = 0; x < num; x++) {
                if (x + 1 == 1) {
                    nth = "First";
                    Console.Write($"Enter the {nth} value: ");
                }
                if (x + 1 == 2) {
                    nth = "Second";
                    Console.Write($"Enter the {nth} value: ");
                }
                if (x + 1 >= 3) {
                    nth = "th";
                    Console.Write($"Enter the {x}{nth} value: ");
                }

                array[x] = Convert.ToInt32(Console.ReadLine());
            }

            for (int x = 0; x < num; x++) {
                for (int y = 0; y < num - 1; y++) {
                    if (array[y] > array[y + 1]) {
                        temp = array[y];
                        array[y] = array[y + 1];
                        array[y + 1] = temp;
                    }
                }
            }

            Console.WriteLine("In ASC order..,");
            for (int x = 0; x < num; x++) {
                Console.WriteLine(array[x]);
            }

        }

        public static void CountPrintExecution() {
            int x, y, z, count = 0;
            for (x = 0; x <= 3; x++) {

                for (y = 0; y <= 3; y++) {

                    for (z = 0; z <= 3; z++) {

                        if (x == 3 && y == 3 && z == 3) {
                            break;
                        } else {
                            //This needs to be reworked
                            count++;
                            Console.WriteLine("X " + x + "Y " + y + "Z " + z);
                        }
                    }
                }
            }
            Console.WriteLine("In this program, writeline will print " + count + " times.");
        }

        public static void ShowPrimeNumbers() {
            int[] array = new int[10];
            int count = 0, i, j, k = 2;
            Console.WriteLine("Enter up to 10 values:");
            for (i = 0; i < 10; i++) {
                Console.Write(i + 1 + ": ");
                array[i] = Convert.ToInt32(Console.ReadLine());
            }
            for (j = 0; j < 10; j++) {
                for (k = 2; j < array[count]; k++) {
                    if (array[count] % k == 0) {
                        goto to;
                    }
                }
            to: if (k == array[count]) {
                    Console.WriteLine("Entered value: " + array[count] + " is prime number");
                }
                if (array[count] == 0 || array[count] == 1) {
                    Console.WriteLine("Entered value : " + array[count] + " is not prime number");
                }
                count++;
            }
        }

        public static void DuplicateCount() {
            int space = 7;
            int num = 1;
            for (int x = 1; x < 5; x++) {
                for (int y = 1; y <= space; y++) {
                    Console.Write(" ");
                }
                space = space - 2;
                for (int z = 1; z <= x; z++) {
                    Console.Write(num);
                    Console.Write(" ");
                    num++;
                }
                Console.WriteLine("\n");
            }
            Console.ReadLine();
        }

        public static void PrintASCIIValues() {
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

        public static void PrintOutput() {
            //Write a program using a loop that prints the following output.
            //1 2 2 3 3 3 4 4 4 4 5 5 5 5 5 6 6 6 6 6 6. . .nth iteration.
            int value;
            Console.WriteLine("Enter a value: ");

            value = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\n");

            for (int x = 0; x <= value; x++) {
                for (int y = 1; y <= x; y++) {
                    Console.Write(x);
                }
                Console.Write(" ");
            }
            Console.ReadLine();
        }

        public static void Iteration() {
            //Write a program using a for loop that prints the following series.
            //1 2 4 8 16 21 64 128 …nth iteration.
            int value;
            double result;
            Console.WriteLine("Enter some value");

            value = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Here are the iteration: ");

            for (int x = 0; x <= value; x++) {
                result = Math.Pow(2, x);
                Console.Write(result);
                Console.Write(" ");
            }
            Console.ReadKey();
        }

        public static void IdentityMatrix() {
            //Write a program that prints an identity matrix using a for loop,
            //in other words takes a value n from the user and shows the identity table of size n * n.
            int size;
            Console.WriteLine("Enter the size of the identity matrix");
            size = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Identity Matrix");
            for (int i = 0; i < size; i++) {
                for (int j = 0; j < size; j++) {
                    if (i == j) {
                        Console.Write(1);
                    } else {
                        Console.Write(0);
                    }
                }
                Console.WriteLine("\n");
            }
            Console.ReadLine();
        }

        public static void LeapYear() {
            //Instruction:
            //Write a program using conditional operators to determine whether a year entered through the keyboard is a leap year or not.

            int year;
            string response;
            Console.WriteLine("Enter a Year:");
            year = Convert.ToInt32(Console.ReadLine());
            if (year % 4 == 0) {
                response = "Year is leap";
            } else {
                response = "Not a leap year";
            }
            //I can use a Ternary operation too
            //response = year % 4 == 0 ? "Year is leap year." : "Year is not a leap year.";
            Console.WriteLine(response);
        }
    }
}