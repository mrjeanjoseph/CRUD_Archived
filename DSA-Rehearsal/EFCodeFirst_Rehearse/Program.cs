using System;
using System.IO;
using EFCodeFirst_Rehearse.DAL;
using Microsoft.Extensions.Configuration;

namespace EFCodeFirst_Rehearse {
    class Program {
        private static IConfiguration _iconfig;
        static void Main(string[] args) {
            Console.WriteLine("Getting all IDs");
            PrintEmployeeList();
        }

        static void PrintEmployeeList() {
            var empDAL = new EmployeeDAL(_iconfig);
            var empListModel = empDAL.GetEmployeeList();
            empListModel.ForEach(emp => Console.WriteLine(emp.Id));

            Console.ReadKey();
        }
    }
}
