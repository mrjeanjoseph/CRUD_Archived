using System;
using System.Collections.Generic;

namespace BasicAlgorithms.Deux {
    class Program {
        static void Main(string[] args) {

            Console.WriteLine(CalculateSquareRoot(81));
            Console.ReadLine();
            /*
            string[] arr_strings = { "Where", "Who", "What", "Whatever" };
            Console.WriteLine($"{string.Join(", ", arr_strings)}");
            Console.WriteLine(GetLongestArrayOfStrings(arr_strings));
            
            ListAllPrimeInDescendingOrder();*/
        }

        public static int CalculateSquareRoot(double num) {
            int sq = 1;
            while (sq < num / sq) {
                sq++;
            }
            if (sq > num / sq) return sq - 1;
            return sq;
        }

        public static string GetLongestArrayOfStrings(string[] arr_strings) {
            //Finds the longest common prefix from an array of strings.
            if (arr_strings.Length == 0 || Array.IndexOf(arr_strings, "") != -1)
                return "";
            string result = arr_strings[0];
            int i = result.Length;
            foreach (string word in arr_strings) {
                int j = 0;
                foreach (char c in word) {
                    if (j >= i || result[j] != c)
                        break;
                    j += 1;
                }
                i = Math.Min(i, j);
            }
            return result.Substring(0, i);
        }

        static void ListAllPrimeInDescendingOrder() {
            //Create and display a list of all prime numbers in ascending order
            Console.WriteLine("Displaying a list of prime numbers in ascending order");
            uint z = 0; int nc;
            var p = new uint[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            var nxt = new uint[128];

            while (true) {
                nc = 0;
                foreach (var x in p) {
                    if (IsPrime(x))
                        Console.Write("{0,8}{1}", x, ++z % 5 == 0 ? "\n" : " ");

                    for (uint y = x * 10, l = x % 10 + y++; y < l; y++)
                        nxt[nc++] = y;
                }
                if (nc > 1) {
                    Array.Resize(ref p, nc); Array.Copy(nxt, p, nc);
                } else break;
            }

            Console.WriteLine("\n{0} descending primes found", z);
        }
        static void ListAllPrimeInAscendingOrder() {
            //Create and display a list of all prime numbers in ascending order
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
