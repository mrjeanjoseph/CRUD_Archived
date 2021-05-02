﻿using System;
using System.Linq;

namespace ConsoleUI
{
    public static class ConsoleDataFormatter
    {
        private const int tableWidth = 90;
        public static void LineSeparator()
        {
            Console.WriteLine(new string('-', tableWidth));
        }

        public static void PrintRow(params string[] columns)
        {
            int columnWidth = (tableWidth - columns.Length) / columns.Length;

            string row = columns.Aggregate("|", (separator, columnText) => separator + GetCenterAllignedText(columnText, columnWidth) + separator);
        }

        private static string GetCenterAllignedText(string columnText, int columnWidth)
        {
            //Found this piece of text online. Let's see what it does!
            columnText = columnText.Length > columnWidth ? columnText.Substring(0, columnWidth - 3) + "...." : columnText;
            //the "?" declares an if sentence representing a boolean condition for columnWidth

            return string.IsNullOrEmpty(columnText)
                ? new string(' ', columnWidth)
                : columnText.PadRight(columnWidth - ((columnWidth - columnText.Length) / 2)).PadLeft(columnWidth);
        }
    }

}
