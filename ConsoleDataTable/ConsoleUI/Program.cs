﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleUI
{
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

            DataTableFormatter.LineSeparator();
            DataTableFormatter.PrintRow("Customer Name","Item","Price","Quantity");
            DataTableFormatter.LineSeparator();

            //foreach (Order name in orders)
            //{
            //    DataTableFormatter.PrintRow(name.CustomerName, name.Item, name.Price.ToString(), name.Quantity.ToString());
            //}

            foreach (Order name in distinctOrders)
            {
                DataTableFormatter.PrintRow(name.CustomerName);

                for (int i = 0; i < orders.Count; i++)
                {
                    if (name.CustomerName == orders[i].CustomerName)
                    {
                        DataTableFormatter.PrintRow(name.Item, name.Price.ToString(), name.Quantity.ToString());
                    }
                }
            }
            DataTableFormatter.LineSeparator();
            Console.ReadLine();
        }
    }

}
