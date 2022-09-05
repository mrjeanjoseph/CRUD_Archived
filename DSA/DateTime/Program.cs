using System;
using System.Globalization;

namespace DateTimeReheasals {
    class Program {
        static void Main(string[] args) {

            DiffBetweenTwoDates();
            Console.ReadLine();
        }

        public static void DisplayUTCNowDates() {
            DateTime localDate = DateTime.Now;
            DateTime utcDate = DateTime.UtcNow;
            String[] cultureNames = { "en-US", "en-GB", "fr-FR",
                                "de-DE", "ru-RU", "ht-HT" };

            foreach (var cultureName in cultureNames) {
                var culture = new CultureInfo(cultureName);
                Console.WriteLine("{0}:", culture.NativeName);
                Console.WriteLine("   Local date and time: {0}, {1:G}",
                                  localDate.ToString(culture), localDate.Kind);
                Console.WriteLine("   UTC date and time: {0}, {1:G}\n",
                                  utcDate.ToString(culture), utcDate.Kind);
            }
        }

        public static void DisplayDateTimeValue() {
            DateTime localDate = DateTime.Now;

            DateTime dt1 = new DateTime(2016, 6, 8, 11, 49, 0);
            Console.WriteLine("Complete date: " + dt1.ToString());

            // Get date-only portion of date, without its time.
            DateTime dateOnly = dt1.Date;

            Console.WriteLine("Short Date: " + dateOnly.ToString("d"));

            Console.WriteLine("Display date using 24-hour clock format:");

            Console.WriteLine(dateOnly.ToString("g"));
            Console.WriteLine(dateOnly.ToString("MM/dd/yyyy HH:mm"));
        }

        public static void Display15DatesPerMonth() {
            var dates = new DateTime(2022, 9, 4);
            for (int z = 0; z <= 15; z++)
                Console.WriteLine(dates.AddMonths(z).ToString("d"));
        }

        public static void PastAndFutureDates() {
            DateTime baseDate = new DateTime(2022, 9, 4);
            Console.WriteLine($"Base Date:\t\t {baseDate:d}");
            Console.WriteLine("============================");

            for (int z = 0; z >= -15; z--) {
                //Console.WriteLine("{0,2} year(s) ago:\t\t {1:d}", Math.Abs(z), baseDate.AddYears(z));
                string result1 = Math.Abs(z).ToString("d");
                string result2 = baseDate.AddYears(z).ToString("d");
                Console.WriteLine($"{result1} year (s) ago:\t\t {result2}");
            }

        }

        public static void ComparingTwoDates() {
            DateTime dateOne = new DateTime(2022, 9, 4);
            DateTime dateTwo = new DateTime(2022, 10, 19);

            int result = DateTime.Compare(dateOne, dateTwo);
            string relationship;

            if (result > 0)
                relationship = "is earlier than";
            else if (result == 0)
                relationship = "is the same date/time as";
            else
                relationship = "is later than";

            Console.WriteLine($"{dateOne.ToString("M")} {relationship} {dateTwo.ToString("M")}");
        }

        public static void ComparePastDateAndFutureDates() {
            DateTime thisDate = DateTime.Today;
            DateTime thisDateNextYear, thisDateLastYear;

            //  add/substract 1 year
            thisDateNextYear = thisDate.AddYears(1);
            thisDateLastYear = thisDate.AddYears(-1);

            DateCompare comparison;
            // Compare today to last year
            comparison = (DateCompare)thisDate.CompareTo(thisDateLastYear);
            Console.WriteLine("{0}: {1:d} is {2} than {3:d}",
                              (int)comparison, thisDate, comparison.ToString().ToLower(),
                              thisDateLastYear);

            // Compare today to next year
            comparison = (DateCompare)thisDate.CompareTo(thisDateNextYear);
            Console.WriteLine("{0}: {1:d} is {2} than {3:d}",
                              (int)comparison, thisDate, comparison.ToString().ToLower(),
                              thisDateNextYear);
        }

        public static void CompareCurrentAndGivenDates() {
            DateTime futureDate = new DateTime(DateTime.Today.Year, 9, 5);
            int compareValue;

            try {
                compareValue = futureDate.CompareTo(DateTime.Today);
            } catch (ArgumentException) {
                Console.WriteLine("Value is not a DateTime");
                return;
            }

            if (compareValue < 0)
                Console.WriteLine("{0:d} is in the past.", futureDate);
            else if (compareValue == 0)
                Console.WriteLine("{0:d} is today!", futureDate);
            else // compareValue > 0
                Console.WriteLine("{0:d} has not come yet.", futureDate);

        }

        public static void CompareDateTimeObjects() {

            DateTime one = DateTime.UtcNow;
            DateTime two = DateTime.Now;
            DateTime three = one;

            bool result = one.Equals(two);
            Console.WriteLine("The result of comparing DateTime object one and two is: {0}.", result);

            result = one.Equals(three);
            Console.WriteLine("The result of comparing DateTime object one and three is: {0}.", result);
        }

        public static void DateTimeStringRepresentation() {
            string[] formats = {"M/d/yyyy h:mm:ss tt", "M/d/yyyy h:mm tt",
                         "MM/dd/yyyy hh:mm:ss", "M/d/yyyy h:mm:ss",
                         "M/d/yyyy hh:mm tt", "M/d/yyyy hh tt",
                         "M/d/yyyy h:mm", "M/d/yyyy h:mm",
                         "MM/dd/yyyy hh:mm", "M/dd/yyyy hh:mm"};

            string[] dateStrings = {"8/1/2022 6:32 PM", "01/01/2022 6:32:05 PM",
                              "2/19/2020 6:32:00", "12/08/2019 06:32",
                              "08/06/2019 06:32:00 PM", "05/11/2018 06:32:00"};

            DateTime dateValue;

            foreach (string dateString in dateStrings) {
                if (DateTime.TryParseExact(dateString, formats,
                                           new CultureInfo("zh-CN"),
                                           DateTimeStyles.None,
                                           out dateValue))
                    Console.WriteLine("Converted '{0}' to {1}.", dateString, dateValue);
                else
                    Console.WriteLine("Unable to convert '{0}' to a date.", dateString);
            }
        }

        public static void DateStringRepresentation() {
            DateTime july28 = new DateTime(2009, 7, 28, 5, 23, 15, 16);

            //string[] july28Formats = july28.GetDateTimeFormats();
            string[] july28Formats = july28.GetDateTimeFormats('d');

            // Print out july28 in all DateTime formats using the default culture.
            foreach (string format in july28Formats) {
                Console.WriteLine(format);
            }
        }

        public static void DatesFallWithinRange() {
            DateTime date1 = new DateTime(2016, 3, 14, 2, 30, 00);
            Console.WriteLine("Invalid Time: {0}",
                              TimeZoneInfo.Local.IsInvalidTime(date1));
            long ft = date1.ToFileTime();
            DateTime date2 = DateTime.FromFileTime(ft);
            Console.WriteLine("{0} -> {1}", date1, date2);
        }

        public static void DetermineObjectTypes() {

            object[] values = {
                (int) 24,
                (long) 10653,
                (byte) 24,
                (sbyte) -5,
                26.3,
                "string"
            };

            foreach (var value in values) {
                Type t = value.GetType();
                if (t.Equals(typeof(byte)))
                    Console.WriteLine("{0} is an unsigned byte.", value);
                else if (t.Equals(typeof(sbyte)))
                    Console.WriteLine("{0} is a signed byte.", value);
                else if (t.Equals(typeof(int)))
                    Console.WriteLine("{0} is a 32-bit integer.", value);
                else if (t.Equals(typeof(long)))
                    Console.WriteLine("{0} is a 32-bit integer.", value);
                else if (t.Equals(typeof(double)))
                    Console.WriteLine("{0} is a double-precision floating point.", value);
                else
                    Console.WriteLine("'{0}' is another data type.", value);
            }
        }

        public static void FindLeapYear() {
            int firstYear = 1995;
            int secondYear = 2022;

            for (int year = firstYear; year <= secondYear; year++) {
                if (DateTime.IsLeapYear(year)) {
                    Console.WriteLine("{0} is a leap year.", year);
                    DateTime leapDay = new DateTime(year, 2, 29);
                    DateTime nextYear = leapDay.AddYears(1);
                    Console.WriteLine("   One year from {0} is {1}.",
                                      leapDay.ToString("d"),
                                      nextYear.ToString("d"));
                }
            }
        }

        public static void CalculateLeapYear() {
            Console.WriteLine("Enter Year : ");

            int Year = int.Parse(Console.ReadLine());

            if (((Year % 4 == 0) && (Year % 100 != 0)) || (Year % 400 == 0))
                Console.WriteLine("{0} is a Leap Year.", Year);
            else
                Console.WriteLine("{0} is not a Leap Year.", Year);

        }

        public static void CalculateLeapYear2() {
            int i = 0;
            int[] arr = new int[5];

            Console.WriteLine("Enter years : ");
            for (i = 0; i < arr.Length; i++) {
                Console.Write("Year[" + (i + 1) + "]: ");
                arr[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("List of leap years : ");
            for (i = 0; i < arr.Length; i++) {
                if ((arr[i] % 4 == 0) && (arr[i] % 100 != 0))
                    Console.Write(arr[i] + " ");
                else if ((arr[i] % 4 == 0) && (arr[i] % 100 == 0) && (arr[i] % 400 == 0))
                    Console.Write(arr[i] + " ");
            }
        }

        public static void DiffBetweenTwoDates() {

            //establish DateTimes
            DateTime start = new DateTime(2022, 9, 5);
            DateTime end = new DateTime(2022, 10, 19);

            //create TimeSpan object
            TimeSpan difference = end - start;

            //Extract days, write to Console.
            Console.WriteLine("Difference in days: " + difference.Days);
        }
    }
}
