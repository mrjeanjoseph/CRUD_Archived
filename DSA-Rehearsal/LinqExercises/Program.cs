using System;
using System.Collections.Generic;
using System.Linq;

namespace LinqExercises {
    class Program {
        static void Main(string[] args) {
            List<Student> students = new List<Student> {
                new Student {FirstName="Denzell", LastName="Jean-Joseph", ID=111, Scores= new List<int> {97, 92, 81, 60}},
                new Student {FirstName="Nitaud", LastName="Paniague", ID=112, Scores= new List<int> {75, 84, 91, 39}},
                new Student {FirstName="Jeremiah", LastName="Jean-Joseph", ID=113, Scores= new List<int> {88, 94, 65, 91}},
                new Student {FirstName="Denzell", LastName="Paniague", ID=114, Scores= new List<int> {97, 89, 85, 82}},
                new Student {FirstName="Amelika", LastName="Frederick", ID=115, Scores= new List<int> {35, 72, 91, 70}},
                new Student {FirstName="Fadi", LastName="Fakhouri", ID=116, Scores= new List<int> {99, 86, 90, 94}},
                new Student {FirstName="Hanying", LastName="Feng", ID=117, Scores= new List<int> {93, 92, 80, 87}},
                new Student {FirstName="Hugo", LastName="Garcia", ID=118, Scores= new List<int> {92, 90, 83, 78}},
                new Student {FirstName="Wilio", LastName="Flamman", ID=119, Scores= new List<int> {68, 79, 88, 92}},
                new Student {FirstName="Terry", LastName="Adams", ID=120, Scores= new List<int> {99, 82, 81, 79}},
                new Student {FirstName="Ariel", LastName="Henry", ID=121, Scores= new List<int> {96, 85, 91, 60}},
                new Student {FirstName="Jovenel", LastName="Moise", ID=122, Scores= new List<int> {94, 92, 91, 91}}
            };

            IEnumerable<Student> Query1 =
                from student in students
                    //where student.Scores[0] > 90
                where student.Scores[0] > 90 && student.Scores[3] < 80
                orderby student.LastName ascending
                //orderby student.Scores[0] descending
                select student;

            foreach (Student student in Query1) {
                //Console.WriteLine("{0}, {1}", student.LastName, student.FirstName);
                //Console.WriteLine("{0}, {1} {2}", student.LastName, student.FirstName, student.Scores[0]);

            }

            var Query2 =
                from student in students
                group student by student.LastName[0];

            foreach (var studentGroup in Query2) {
                //Console.WriteLine(studentGroup.Key);
                foreach (Student student in studentGroup) {
                    Console.WriteLine("   {0}, {1}",
                              student.LastName, student.FirstName);
                }
            }

            var Query3 =
                from student in students
                group student by student.LastName[0];

            foreach (var groupOfStudents in Query3) {
                Console.WriteLine(groupOfStudents.Key);
                foreach (var student in groupOfStudents) {
                    Console.WriteLine("   {0}, {1}",
                        student.LastName, student.FirstName);
                }
            }

            var Query4 =
                from student in students
                group student by student.LastName[0] into studentGroup
                orderby studentGroup.Key
                select studentGroup;

            foreach(var bunchStuds in Query4) {
                Console.WriteLine(bunchStuds.Key);
                foreach(var studs in bunchStuds) {
                    Console.WriteLine("{0}, {1}", studs.LastName, studs.FirstName);
                }
            }

            Console.ReadLine();
        }
    }
}
