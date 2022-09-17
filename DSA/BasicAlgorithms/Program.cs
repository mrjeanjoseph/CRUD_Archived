using System;

namespace BasicAlgorithms {
    class Program {
        static void Main(string[] args) {

            //Console.WriteLine(ComputeSumAndTrippleSum(15,15));
            Console.WriteLine(ComputeAbsoluteDiffirence(15));
            Console.WriteLine(ComputeAbsoluteDiffirence(75));
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
        static int ComputeAbsoluteDiffirence(int num) {
            //get the absolute difference between num and 51. If n is greater than 51 return quad the absolute difference.
            const int x = 51;
            const int q = 4;
            if (x > num) {
                return (x - num) * q;
            } else {
                return x - num;
            }
        }
    }
}
