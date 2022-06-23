using System;

namespace WorkerEfficiency
{
    class Program
    {
        static void Main(string[] args)
        {
            int time;
            Console.WriteLine("Enter the time required for a workder to complete a particular job.");
            time = Convert.ToInt32(Console.ReadLine());

            if(time <= 2)
            {
                Console.WriteLine("Worker is highly efficient at his task.");
            }
            if(time > 2 && time <= 5)
            {
                Console.WriteLine("Employee should increase his speed.");
            }
            if(time > 5 && time <= 8)
            {
                Console.WriteLine("Training should be provided to increase production speed.");
            }
            if (time > 8)
            {
                Console.WriteLine("Transitioning process should begin.");
            }

            Console.ReadLine();
        }
    }
}

//In a company, worker efficiency is determined on the basis of the time required for a worker to complete a specific job.
//If the time taken by the worker is between 2 - 3 hours, then the worker is said to be highly efficient.
//If the time required by the worker is 3 - 4 hours, then the worker is ordered to increase their speed.
//If the time taken is 4 - 5 hours then the worker is given training to improve his speed and
//if the time taken by the worker is more than 8 hours then the worker must leave the company.
//If the time taken by the worker is input through the keyboard then find the efficiency of the worker.