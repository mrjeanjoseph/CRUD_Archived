using System;
using System.Net.WebSockets;

namespace MainConsoleUI {
    class Program {
        static void Main(string[] args) {
            Console.Title = "DSA Rehearsals";

            string[] employees = {
                "Louna", "Devereaux", "Veleenah", "Casteeleaux"
            };

            IEnumerable<string> getEmp = from person in employees
                                         orderby person
                                         select person;

            foreach(string emp in getEmp) {
                Console.WriteLine(emp);
            }
            Console.ReadLine();
        }
    }
}