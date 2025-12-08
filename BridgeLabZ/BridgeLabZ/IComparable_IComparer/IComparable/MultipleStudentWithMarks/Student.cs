using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabZ.IComparable_IComparer.IComparable.MultipleStudentWithMarks
{
    class Student : IComparable<Student>
    {
        public string Name { get; set; }
        public List<int> Marks { get; set; } = new List<int>();
        public int TotalMarks()
        {
            int sum = 0;
            foreach (int m in Marks)
                sum += m;
            return sum;
        }
        public int CompareTo(Student other)
        {
            return other.TotalMarks().CompareTo(this.TotalMarks());
        }

        public override string ToString()
        {
            return $"{Name} | Total = {TotalMarks()}";
        }
    }

    class Program
    {
        static void Main()
        {
            Console.Write("Enter number of students: ");
            int n = int.Parse(Console.ReadLine());

            Console.Write("Enter number of subjects for each student: ");
            int subjectCount = int.Parse(Console.ReadLine());

            List<Student> students = new List<Student>();

            for (int i = 0; i < n; i++)
            {
                Student s = new Student();

                Console.Write($"\nEnter name of student {i + 1}: ");
                s.Name = Console.ReadLine();

                Console.WriteLine($"Enter marks of {subjectCount} subjects:");

                for (int j = 0; j < subjectCount; j++)
                {
                    Console.Write($"Subject {j + 1}: ");
                    int mark = int.Parse(Console.ReadLine());
                    s.Marks.Add(mark);
                }

                students.Add(s);
            }
            Console.WriteLine("\nBefore Sorting:");
            foreach (var s in students)
                Console.WriteLine($"{s.Name} -> Total: {s.TotalMarks()}");
            students.Sort();

            Console.WriteLine("\nAfter Sorting by Total Marks (Descending):");
            foreach (var s in students)
                Console.WriteLine($"{s.Name} -> Total: {s.TotalMarks()}");
        }

    }
}