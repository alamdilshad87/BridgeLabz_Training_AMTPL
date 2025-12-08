using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabZ.IComparable_IComparer.IComparable.MultipleStudent
{
    class Student : IComparable<Student>
    {
        public int Roll { get; set; }
        public string Name { get; set; }
        public int CompareTo(Student other)
        {
            return Roll.CompareTo(other.Roll);
        }
        public override string ToString()
        {
            return $"Roll: {Roll}, Name: {Name}";
        }

        internal object TotalMarks()
        {
            throw new NotImplementedException();
        }
    }

    class Program
    {
        static void Main()
        {
            List<Student> students = new List<Student>()
            {
                new Student(){ Roll = 3, Name = "Ali" },
                new Student(){ Roll = 5, Name = "Rahul" },
                new Student(){ Roll = 2, Name = "Neha" },
                new Student(){ Roll = 0, Name = "Zara" }
            };

            Console.WriteLine("Before Sorting:");
            foreach (var s in students)
                Console.WriteLine(s);
            students.Sort();
            Console.WriteLine("\nAfter Sorting by Roll (IComparable):");
            foreach (var s in students)
                Console.WriteLine(s);
        }
    }
}