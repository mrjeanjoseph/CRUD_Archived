﻿using System;
using System.Collections.Generic;

namespace BasicAlgorithms.Deux {
    class Program {
        static void Main(string[] args) {
            ListAllPrimeInAscendingOrder();
            Console.ReadLine();
        }

        static void ListAllPrimeInAscendingOrder() {
            //Create and display all prime numbers in strictly ascending decimal digit order
            Console.WriteLine("Displaying a list of prime numbers in ascending order");
            var Q = new Queue<uint>();
            var prime_nums = new List<uint>();

            for (uint i = 1; i <= 9; i++)
                Q.Enqueue(i);

            while (Q.Count > 0) {
                uint n = Q.Dequeue();
                if (IsPrime(n))
                    prime_nums.Add(n);
                for (uint i = n % 10 + 1; i <= 9; i++)
                    Q.Enqueue(n * 10 + i);
            }

            foreach (uint p in prime_nums) {
                Console.Write($"{p}, ");
            }

            Console.WriteLine();
        }

        public static bool IsPrime(uint n) {
            //Calculate all prime values
            if (n <= 1) { return false; }

            int ctr = 0;
            for (int i = 1; i <= n; i++) {
                if (n % i == 0) { ctr++; }
                if (ctr > 2) {
                    return false;
                }
            }
            return true;
        }
    }
}
