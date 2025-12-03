using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabZ.Inheritance.MultiLevelInheritance
{ 
    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Address { get; set; }

        public Person(string name, int age, string address)
        {
            Name = name;
            Age = age;
            Address = address;
        }

        public void DisplayDetails()
        {
            Console.WriteLine($"Name: {Name}, Age: {Age}, Address: {Address}");
        }
    }
    public class Student : Person
    {
        public string StudentId { get; set; }

        public Student(string name, int age, string address, string studentId)
            : base(name, age, address) 
        {
            StudentId = studentId;
        }

        public void Enroll(string courseName)
        {
            Console.WriteLine($"{Name} has enrolled in {courseName} course.");
        }
    }
    public class Teacher : Person
    {
        public string EmployeeId { get; set; }

        public Teacher(string name, int age, string address, string employeeId)
            : base(name, age, address)
        {
            EmployeeId = employeeId;
        }

        public void Teach(string courseName)
        {
            Console.WriteLine($"{Name} is teaching {courseName} course.");
        }
    }
    public class Program
    {
        static void Main(string[] args)
        {
            Student john = new Student("Md Dilshad Alam", 22, "Chennai", "21CSE");
            john.DisplayDetails();
            john.Enroll("BridgeLabZ_OOPS");

            Console.WriteLine();

            Teacher mrsSmith = new Teacher("Chandrasekhar", 30, "Estancia", "21CSE");
            mrsSmith.DisplayDetails();
            mrsSmith.Teach("OOPS");

            Console.Read();
        }
    }
}