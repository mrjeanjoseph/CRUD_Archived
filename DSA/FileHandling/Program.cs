using System;
using System.IO;

namespace FileHandling {
    class Program {
        static void Main(string[] args) {

            string fileName = @"crudtmpfile.txt";
            ReCreateCrudFiles(fileName);


            Console.WriteLine();
        }

        public static void CreateCrudFiles(string fileName) {

            try {
                Console.WriteLine("Creating a new file in the disk");

                using (FileStream fileStr = File.Create(fileName)){
                    //This will save the file in the netcore folder
                    Console.WriteLine($"File {fileName} was created successfully.");
                }

            } catch (Exception e) {

                Console.WriteLine(e.Message);
            }
        }

        public static void DeleteCrudFiles(string fileName) {

            Console.WriteLine("In the process of deleting the file. Please wait...,");
            Console.WriteLine("---");

            if (File.Exists(fileName)){
                File.Delete(fileName);

                Console.WriteLine($"File {fileName} has been deleted.");
            } else {
                Console.WriteLine($"File {fileName} cannot be deleted or does not exist");
            }

        }

        public static void ReCreateCrudFiles(string fileName) {
            try {
                Console.WriteLine(@"In the process of creating a new file.");
                if (File.Exists(fileName)) {
                    Console.WriteLine("Existing same name files will be deleted.");

                    File.Delete(fileName);
                }
                using(FileStream fileStr = File.Create(fileName)) {
                    Console.WriteLine($"File {fileName} has been created");
                }
            } catch(Exception ex) {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
