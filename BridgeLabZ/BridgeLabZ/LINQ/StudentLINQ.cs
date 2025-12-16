using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabZ.LINQ
{
    internal class StudentLINQ
    {
        class Student
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public int Marks { get; set; }
            public string City { get; set; }
        }

        class Program
        {
            static void Main(string[] args)
            {
                List<Student> students = new List<Student>()
                {
                    new Student { Id = 1, Name = "Gaurav",  Marks = 85, City = "Banaras" },
                    new Student { Id = 2, Name = "Pranav",  Marks = 72, City = "Himachal" },
                    new Student { Id = 3, Name = "Dilshad", Marks = 90, City = "Dhanbad" },
                    new Student { Id = 4, Name = "Adarsh",  Marks = 65, City = "Singhroli" }
                };

                var highScorers = students.Where(s => s.Marks > 75);
                Console.WriteLine("Students with Marks > 75:");
                foreach (var s in highScorers)
                    Console.WriteLine($"{s.Name} - {s.Marks}");

                var names = students.Select(s => s.Name);
                Console.WriteLine("\nStudent Names:");
                foreach (var name in names)
                    Console.WriteLine(name);

                var sorted = students.OrderByDescending(s => s.Marks);
                Console.WriteLine("\nStudents Sorted by Marks:");
                foreach (var s in sorted)
                    Console.WriteLine($"{s.Name} - {s.Marks}");

                var groupByCity = students.GroupBy(s => s.City);
                Console.WriteLine("\nStudents Grouped by City:");
                foreach (var group in groupByCity)
                {
                    Console.WriteLine(group.Key);
                    foreach (var s in group)
                        Console.WriteLine("  " + s.Name);
                }
                
                int maxMarks = students.Max(s => s.Marks);
                double avgMarks = students.Average(s => s.Marks);
                Console.WriteLine("\nMaximum Marks: " + maxMarks);
                Console.WriteLine("Average Marks: " + avgMarks);

                var topper = students.First(s => s.Marks > 80);
                bool isFromDelhi = students.Any(s => s.City == "Delhi");
                Console.WriteLine("\nTopper: " + topper.Name);
                Console.WriteLine("Any student from Delhi? " + isFromDelhi);
                Console.ReadLine();
            }
        }
    }
}