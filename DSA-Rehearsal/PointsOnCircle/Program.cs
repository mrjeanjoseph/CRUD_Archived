using System;

namespace PointsOnCircle
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, y, radius, radius_square, coordinates_calculation;

            Console.WriteLine("Enter X coordinates of circle:");
            x = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Y coordinates of circle:");
            y = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Radius of circle:");
            radius = Convert.ToInt32(Console.ReadLine());

            //Equation of a circle is (x-a)^2+(y-b)^2=r^2
            radius_square = radius * radius;
            //And here at the origin (0,0)
            coordinates_calculation = (x * x) + (y * y);

            if (coordinates_calculation == radius_square)
            {
                Console.WriteLine("Points lies on the circle");
            }

            if (coordinates_calculation > radius_square)
            {
                Console.WriteLine("Points lies outside the circle");
            }

            if (coordinates_calculation < radius_square)
            {
                Console.WriteLine("Points lies inside the circle");
            }

            Console.ReadLine();
        }
    }
}

// Write a program that takes coordinates (x, y) of a center of a circle and its radius from the user, the program will determine whether a point lies inside the circle, on the circle or outside the circle.