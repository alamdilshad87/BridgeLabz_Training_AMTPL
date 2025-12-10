using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabZ.Lambdas
{
    class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Marks { get; set; }
    }

    internal class LambdaStudentClass
    {
        public static void Main()
        {
            List<Student> students = new List<Student>()
            {
                new Student { Id = 1, Name = "Om", Marks = 85 },
                new Student { Id = 2, Name = "Pranav", Marks = 92 },
                new Student { Id = 3, Name = "Adarsh", Marks = 76 },
                new Student { Id = 4, Name = "Gaurav", Marks = 60 },
                new Student { Id = 5, Name = "Dilshad", Marks = 95 }
            };

            var highScorers = students.Where(s => s.Marks > 80);
            var studentOm = students.Find(s => s.Name == "Om");
            bool anyFail = students.Any(s => s.Marks < 35);
            var sortedByMarks = students.OrderBy(s => s.Marks);
            var sortedByNameDesc = students.OrderByDescending(s => s.Name);
            var names = students.Select(s => s.Name);
            int toppersCount = students.Count(s => s.Marks > 90);

            Console.WriteLine("Students with Marks > 80:");
            foreach (var s in highScorers)
                Console.WriteLine($"{s.Name} - {s.Marks}");

            Console.WriteLine("\nFind Student Named Om:");
            Console.WriteLine($"{studentOm.Id} {studentOm.Name} {studentOm.Marks}");

            Console.WriteLine($"\nAny Student Failed? {anyFail}");

            Console.WriteLine("\nStudents Sorted by Marks:");
            foreach (var s in sortedByMarks)
                Console.WriteLine($"{s.Name} - {s.Marks}");

            Console.WriteLine("\nStudents Sorted by Name Descending:");
            foreach (var s in sortedByNameDesc)
                Console.WriteLine($"{s.Name} - {s.Marks}");

            Console.WriteLine("\nAll Student Names:");
            foreach (var n in names)
                Console.WriteLine(n);

            Console.WriteLine($"\nCount of Students with Marks > 90: {toppersCount}");

            Console.ReadLine();
        }
    }
}
