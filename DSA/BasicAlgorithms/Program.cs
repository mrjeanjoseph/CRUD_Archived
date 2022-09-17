using System;

namespace BasicAlgorithms {
    class Program {
        static void Main(string[] args) {

            Console.WriteLine(ComputeSumAndTrippleSum(15,15));
            Console.ReadLine();
        }

        static int ComputeSumAndTrippleSum(int x, int y) {
            //compute the sum of the two given integer values. If the two values are the same, then return triple their sum

            if (x == y) {
                return (x + y) * 3;
            } else {
                return x + y;
            }
        }
    }
}
