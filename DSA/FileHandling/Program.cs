using System;
using System.IO;

namespace FileHandling {
    class Program {
        static void Main(string[] args) {

            string fileName = @"crudtmpfile.txt";
            AppendTextToFile(fileName); 


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
                    File.Delete(fileName);
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

            try {
                CreateFileAndContent(fileName);
                using (StreamReader reader = File.OpenText(fileName)) {
                    string r = "";
                    Console.WriteLine($"Here are the content from the {fileName} file:\n");
                    while((r = reader.ReadLine()) != null) {
                        Console.WriteLine($"\t {r}");
                    }
                    Console.WriteLine("");
                }

            } catch (Exception ex) {
                Console.WriteLine(ex.Message.ToString());
                
            }
        }

        public static void WriteTextArrToFile(string fileName) {
            string[] Lines;
            int numLines, z;

            Console.WriteLine($"Checking if file {fileName} already exist");
            if (File.Exists(fileName)) {
                Console.WriteLine($"File {fileName} is being deleted.");

                File.Delete(fileName);
            }
            Console.WriteLine("How many lines do you want to write in the file?");
            numLines = Convert.ToInt32(Console.ReadLine());
            Lines = new string[numLines];
            Console.WriteLine($"Input {numLines} strings below");

            for(z = 0; z < numLines; z++) {
                Console.WriteLine($"Input {numLines} {z + 1}");
                Lines[z] = Console.ReadLine();
            }
            File.WriteAllLines(fileName, Lines);

            using (StreamReader reader = File.OpenText(fileName)) {
                string r = "";
                Console.WriteLine($"Here are the content from the {fileName} file:\n");
                while ((r = reader.ReadLine()) != null) {
                    Console.WriteLine($"\t {r}");
                }
                Console.WriteLine("");
            }
        }

        public static void AppendTextToFile(string fileName) {
            try {
                Console.WriteLine(@"In the process of creating a new file.");
                if (File.Exists(fileName)) {
                    Console.WriteLine("Existing same name files will be deleted and a new one recreated.");

                    File.Delete(fileName);
                }

                //Maybe the above code needs to go
                Console.WriteLine("\n\nAppending text to an existing file:\n");
                Console.WriteLine("-----------------------------------------");

                using (StreamWriter writer = File.CreateText(fileName)) {
                    writer.WriteLine("I am appending new lines to this text");
                    writer.WriteLine("This is the first content and it looks good");
                    writer.WriteLine("This is the second content and it looks even better");
                }

                using (StreamReader reader = File.OpenText(fileName)) {
                    string data = "";
                    Console.WriteLine($"Here are the content of the file {fileName}");
                    while ((data = reader.ReadLine()) != null) {
                        Console.WriteLine(data);
                    }
                    Console.WriteLine("");
                }

                using (StreamWriter file = new StreamWriter(fileName, true)) {
                    file.WriteLine("This is the line appended at the last line.");
                }

                using(StreamReader file = File.OpenText(fileName)) {
                    string data = "";
                    Console.WriteLine($"Here is the content of the file after appending the text: ");
                    while((data = file.ReadLine()) != null) {
                        Console.WriteLine(data);
                    }
                    Console.WriteLine("");
                }

            } catch (Exception ex) {
                Console.WriteLine(ex.Message.ToString());
            }
        }

        public static void CreateCopyFiles(string fileName) {
            
            string fileOne = @"fileOne.txt";
            string fileTwo = @"fileTwo.txt";

            Console.WriteLine(@"In the process of creating a new file.");
            if (File.Exists(fileOne)) {
                Console.WriteLine("Existing same name files will be deleted and a new one recreated.");

                File.Delete(fileOne);
            }
            Console.WriteLine("\n\nCreating a file, then copying the file");
            Console.WriteLine("------------------------------------------");

            using(StreamWriter writer = File.CreateText(fileOne)) {
                writer.WriteLine("I am now created file number one");
                writer.WriteLine("These are all original content");
                writer.WriteLine("I am good at what I do and I am the master of my code");
            }

            using (StreamReader reader = File.OpenText(fileOne)) {
                string data = "";
                Console.WriteLine($"Here are the content inside of file {fileOne}:");
                while ((data = reader.ReadLine()) != null) {
                    Console.WriteLine(data);
                }
                Console.WriteLine("");
            }

            //working on getting the folder path for source and target
            string sourceFolder = "folderpath";
            string targetFolder = "folderpath";
            string sourceFile = Path.Combine(sourceFolder, fileOne);
            string targetFile = Path.Combine(targetFolder, fileTwo);

            if (Directory.Exists(targetFolder))
                Directory.CreateDirectory(targetFolder);

            File.Copy(sourceFile, targetFile, true);
            File.Copy(sourceFile, targetFile, true);

            Console.WriteLine($"The file {fileOne} successfully copied to the same {fileTwo}");

            using (StreamReader reader = File.OpenText(fileOne)) {
                string data = "";
                Console.WriteLine($"Here is the content of the file inside of {fileOne}");
                while ((data = reader.ReadLine()) != null) {
                    Console.WriteLine(data);
                }
                Console.WriteLine("");
            }

        }
    }
}
