using System;

namespace StructureRehearsals {
    class Program {
        static void Main(string[] args) {

            ExerciseTwo();
            Console.ReadLine();
        }

        public static void ExerciseTwo() {
            Console.WriteLine("Declaring a structure with the use of static fields:");
            Console.WriteLine("====================================================");

            int result = ExerciseTwoStruct.x + ExerciseTwoStruct.y;
            Console.WriteLine($"The sum of x and y using static struct is: {result}");
        }

        public static void ExerciseOne() {
            Console.WriteLine("Declaring a simple struct: ");
            Console.WriteLine("===========================");

            ExerciseOneStruct exstruct = new ExerciseOneStruct();
            exstruct.x = 71;
            exstruct.y = 29;
            int xytotal = exstruct.x + exstruct.y;
            Console.WriteLine($"The sum of x and y is {xytotal}");
        }
    }
}
