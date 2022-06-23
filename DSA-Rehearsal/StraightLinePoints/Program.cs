using System;

namespace StraightLinePoints
{
    class Program
    {
        static void Main(string[] args)
        {
            int x1, x2, x3, y1, y2, y3;
            int slope1, slope2, slope3;

            Console.WriteLine("Enter the values of x1 and y1 coordinates of the first point");
            x1 = Convert.ToInt32(Console.ReadLine());
            y1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the values of x2 and y2 coordinates of the second point");
            x2 = Convert.ToInt32(Console.ReadLine());
            y2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the values of x3 and y3 coordinates of the third point");
            x3 = Convert.ToInt32(Console.ReadLine());
            y3 = Convert.ToInt32(Console.ReadLine());

            slope1 = y2 - y1 / x2 - x1;
            slope2 = y3 - y1 / x3 - x1;
            slope3 = y3 - y2 / x3 - x2;

            if (slope1 == slope2 && slope1 == slope3)
            {
                Console.WriteLine("All points fall on one straight line.");
            }
            else
            {
                Console.WriteLine("Points did not fall on a straight line.");
            }

            Console.ReadLine();

        }
    }
}