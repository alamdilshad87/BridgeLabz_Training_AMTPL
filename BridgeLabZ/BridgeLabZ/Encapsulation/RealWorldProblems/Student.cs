using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabZ.Encapsulation.RealWorldProblems
{
    internal class Student
    {
        private int rollNumber;
        private string name;
        private double marks;

        public void SetDetails(int r, string n, double m)
        {
            if (r > 0)
                rollNumber = r;
            else
                Console.WriteLine("Invalid Roll Number!");

            if (!string.IsNullOrEmpty(n))
                name = n;
            else
                Console.WriteLine("Name cannot be empty!");

            if (m >= 0 && m <= 100)
                marks = m;
            else
                Console.WriteLine("Marks must be between 0 and 100!");
        }

        public void DisplayDetails()
        {
            Console.WriteLine("Student Roll No: " + rollNumber);
            Console.WriteLine("Student Name: " + name);
            Console.WriteLine("Marks: " + marks);
        }

        static void Main()
        {
            Student s1 = new Student();
            s1.SetDetails(101, "Dilshad", 92.5);
            s1.DisplayDetails();

            Console.WriteLine();

            Student s2 = new Student();
            s2.SetDetails(-5, "", 110);
            s2.DisplayDetails();
        }
    }
}
