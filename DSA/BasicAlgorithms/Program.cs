using System;

namespace BasicAlgorithms {
    class Program {
        static void Main(string[] args) {

            //Console.WriteLine(ComputeSumAndTrippleSum(15,15));
            //Console.WriteLine(ComputeAbsoluteDiffirence(15));
            Console.WriteLine(CheckTwoValueIfTrue(25,5));
            Console.WriteLine(CheckTwoValueIfTrue(30,5));
            Console.WriteLine(CheckTwoValueIfTrue(25,15));
            Console.ReadLine();
        }

        static bool CheckTwoValueIfTrue(int a, int b) {
            //Check two given integers, and return true if one of them is 30 or if their sum is 30.
            //return a == 30 || b == 30 || (a + b == 30);
            if(a == 30) return true;
            if(b == 30) return true;
            if (a + b == 30) return true;
            else return false;
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
