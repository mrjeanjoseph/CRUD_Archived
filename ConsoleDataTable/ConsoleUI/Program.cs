using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleUI
{
    public static class ConsoleDataFormatter
    {
        private const int tableWidth = 90;
        public static void LineSeparator()
        {
            Console.WriteLine(new string ('-', tableWidth));
        }

        public static void PrintRow(params string[] columns)
        {
            int columnWidth = (tableWidth - columns.Length) / columns.Length;

            string row = columns.Aggregate("|", (separator, columnText) => separator + GetCenterAllignedText(columnText, columnWidth) + separator);
        }

        private static string GetCenterAllignedText(string columnText, int columnWidth)
        {
            //Found this piece of text online. Let's see what it does!
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            List<Order> orders = new List<Order>
            {
                new Order("Acme Hardware", "Mouse", 25, 3),
                new Order("Acme Hardware", "Keyboard", 45, 2),
                new Order("Falls Realty", "Macbook", 800, 2),
                new Order("Julie’s Morning Diner", "iPad", 525, 1),
                new Order("Julie’s Morning Diner", "Credit Card Reader", 45, 1),
            };

            var distinctOrders = orders.GroupBy(o => o.CustomerName).Select(o => o.First());

            foreach (Order name in distinctOrders)
            {
                Console.WriteLine(name.CustomerName);
                Console.WriteLine(string.Format("\t{0, -20} {1, -20} {2, -20} {3, 0}", "Item", "Price", "Quantity", "Total"));

                for (int i = 0; i < orders.Count; i++)
                {
                    if (name.CustomerName == orders[i].CustomerName)
                    {
                        Console.WriteLine(orders[i].ToString());
                    }
                }

                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }

}
