using System;
using System.IO;
using EFCodeFirst_Rehearse.DAL;
using Microsoft.Extensions.Configuration;

namespace EFCodeFirst_Rehearse {
    class Program {
        private static IConfiguration _iconfig;
        static void Main(string[] args) {
            Console.WriteLine("Getting all IDs");

            GetAppSettingsFile();

            PrintEmployeeList();
        }

        static void GetAppSettingsFile() {
            var builder = new ConfigurationBuilder();
            builder.SetBasePath(Directory.GetCurrentDirectory());
            builder.AddJsonFile("jsconfig.json", optional: false, reloadOnChange: true);
            _iconfig = builder.Build(); 
        }

        static void PrintEmployeeList() {
            var empDAL = new EmployeeDAL(_iconfig);
            var empListModel = empDAL.GetEmployeeList();
            empListModel.ForEach(emp => Console.WriteLine($"{emp.Id} - {emp.EmployeeFirstName}"));

            Console.ReadKey();
        }
    }
}
