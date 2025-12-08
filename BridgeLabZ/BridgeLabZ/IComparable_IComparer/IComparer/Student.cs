using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabZ.IComparable_IComparer.IComparer
{
    class Student : IComparable<Student>
    {
        public string Name { get; set; }
        public int Roll { get; set; }
        public int Marks { get; set; }
        public int CompareTo(Student other)
        {
            return this.Roll.CompareTo(other.Roll);
        }
        public override string ToString()
        {
            return $"Roll: {Roll}, Name: {Name}, Marks: {Marks}";
        }
    }

    class SortByName : IComparer<Student>
    {
        public int Compare(Student x, Student y)
        {
            return x.Name.CompareTo(y.Name);
        }
    }

    class SortByMarksDesc : IComparer<Student>
    {
        public int Compare(Student x, Student y)
        {
            return y.Marks.CompareTo(x.Marks);
        }
    }

    class Program
    {
        static void Main()
        {
            List<Student> students = new List<Student>()
            {
                new Student(){ Roll = 3, Name = "Ali", Marks = 75 },
                new Student(){ Roll = 1, Name = "Rahul", Marks = 90 },
                new Student(){ Roll = 2, Name = "Neha", Marks = 85 },
                new Student(){ Roll = 5, Name = "Aliya", Marks = 95 },
            };

            Console.WriteLine("Before Sorting:");
            foreach (var s in students)
                Console.WriteLine(s);

            students.Sort();
            Console.WriteLine("\nAfter Sorting by Roll (IComparable):");
            foreach (var s in students)
                Console.WriteLine(s);

            students.Sort(new SortByName());
            Console.WriteLine("\nAfter Sorting by Name (IComparer):");
            foreach (var s in students)
                Console.WriteLine(s);

            students.Sort(new SortByMarksDesc());
            Console.WriteLine("\nAfter Sorting by Marks DESC (IComparer):");
            foreach (var s in students)
                Console.WriteLine(s);
        }
    }
}