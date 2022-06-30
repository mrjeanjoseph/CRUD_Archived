using System;
using System.Threading;

namespace BasicDSAChallenges {
    class Program {
        static void Main(string[] args) {
            Console.Title = "Basic DSA Tutorials";

            while (true) {
                try {

                    Console.WriteLine(TripleSum(6,3));
                    Console.WriteLine(TripleSum(5,5));

                } catch (Exception e) {

                    Console.WriteLine("Jean found an error: \n" + e.Message);

                } finally {

                    Console.WriteLine("\nPress any key to continue. \n\tProgram will restart.");
                    Console.ReadLine();
                    Console.Clear();
                }
            }

        }

        public static int TripleSum(int x, int y) {
            if (x == y)
                return (x + y) * 3;
            else
                return (x + y);
            
        }
    }
}
