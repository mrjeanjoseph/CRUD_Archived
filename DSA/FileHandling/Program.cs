using System;
using System.IO;

namespace FileHandling {
    class Program {
        static void Main(string[] args) {

            string fileName = @"crudtmpfile.txt";
            CreateFileAndContent(fileName);


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
                    Console.WriteLine("Existing same name files will be deleted and a new one recreated.");

                    File.Delete(fileName);
                }
                using(FileStream fileStr = File.Create(fileName)) {
                    Console.WriteLine($"File {fileName} has been created");
                }
            } catch(Exception ex) {
                Console.WriteLine(ex.Message);
            }
        }

        public static void CreateFileAndContent(string fileName) {
            
            try {
                Console.WriteLine($"Checking if file {fileName} already exist");
                if (File.Exists(fileName)) {
                    Console.WriteLine($"File {fileName} is being deleted.");
                }

                using (StreamWriter writer = File.CreateText(fileName)) {
                    Console.WriteLine("A new file created and content added");

                    writer.WriteLine("Hello C# and .Net Core");
                    writer.WriteLine("Content is being added everytime the project is ran");
                    writer.WriteLine("Learning new technologies and framework everyday");
                    writer.WriteLine("Then I crud all day, everyday");
                }

            } catch (Exception ex) {
                Console.WriteLine(ex.Message.ToString());
            }
        }

        public static void ReadFileContent(string fileName) {

        }
    }
}
