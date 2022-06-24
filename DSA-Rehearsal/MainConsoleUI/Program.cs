using System;

namespace MainConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            //Polymorphism - overloading
            TestData td = new TestData();
            int addThreeVal = td.Add(2, 5, 9);
            int addTwoVal = td.Add(15,1);

            //
            Department dpt = new Department();
            string newName = dpt.DepartmentName;
            newName = "Robotics";
            Console.WriteLine("Department Name is: {0}", newName);
            Console.ReadLine();
        }
    }
    
    public class TestData
    {
        //Method overloading
        public int Add(int a, int b, int c)
        {
            return a + b + c;
        }

        public int Add(int a, int b)
        {
            return a + b;
        }
    }

    public class Department
    {
        private string departmentname;
        public string DepartmentName
        {
            get { return departmentname; }
            set { departmentname = value; }
        }
    }
}