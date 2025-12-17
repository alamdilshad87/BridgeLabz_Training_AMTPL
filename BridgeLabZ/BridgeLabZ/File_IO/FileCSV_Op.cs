using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;

namespace BridgeLabZ.File_IO
{
    internal class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
    }

    internal class FileCSV_Op
    {
        static string path = "Students.csv";

        // Create CSV
        public static void CreateCSV()
        {
            using (StreamWriter writer = new StreamWriter(path))
            {
                writer.WriteLine("Id,Name,Age");
                writer.WriteLine("1,Dilshad,21");
                writer.WriteLine("2,Aman,22");
                writer.WriteLine("3,Rahul,20");
            }
            Console.WriteLine("\nCSV Created");
            PrintCSV();
        }

        // Read CSV
        public static void PrintCSV()
        {
            Console.WriteLine("Current CSV Content:");
            foreach (string line in File.ReadAllLines(path))
                Console.WriteLine(line);
            Console.WriteLine();
        }

        // Append CSV
        static void AppendStudent(Student s)
        {
            using (StreamWriter writer = File.AppendText(path))
            {
                writer.WriteLine($"{s.Id},{s.Name},{s.Age}");
            }
            Console.WriteLine("Student Appended");
            PrintCSV();
        }

        // Read CSV as Objects
        static List<Student> ReadCsvAsObjects()
        {
            List<Student> students = new List<Student>();

            foreach (string line in File.ReadAllLines(path).Skip(1))
            {
                string[] data = line.Split(',');

                if (data.Length == 3)
                {
                    students.Add(new Student
                    {
                        Id = int.Parse(data[0]),
                        Name = data[1],
                        Age = int.Parse(data[2])
                    });
                }
            }
            return students;
        }

        // Validate CSV
        static void ValidateCSV(List<Student> students)
        {
            Console.WriteLine("Validating CSV Records:");
            foreach (var s in students)
            {
                if (s.Id <= 0 || string.IsNullOrEmpty(s.Name) || s.Age <= 0)
                    Console.WriteLine("Invalid Record Found");
            }
            Console.WriteLine("Validation Completed\n");
        }

        // Search Student
        static void SearchStudent(List<Student> students, string name)
        {
            Console.WriteLine($"Searching for {name}:");
            foreach (var s in students.Where(s => s.Name == name))
                Console.WriteLine($"{s.Id},{s.Name},{s.Age}");
            Console.WriteLine();
        }

        // Update Student
        static void UpdateStudent(List<Student> students, string name, int newAge)
        {
            foreach (var s in students)
            {
                if (s.Name == name)
                    s.Age = newAge;
            }
            Console.WriteLine($"Student '{name}' Updated");
            WriteObjectsToCSV(students);
            PrintCSV();
        }

        // Delete Student
        static void DeleteStudent(List<Student> students, string name)
        {
            students.RemoveAll(s => s.Name == name);
            Console.WriteLine($"Student '{name}' Deleted");
            WriteObjectsToCSV(students);
            PrintCSV();
        }

        // Sort CSV by Age
        static void SortByAge(List<Student> students)
        {
            students.Sort((a, b) => a.Age.CompareTo(b.Age));
            Console.WriteLine("CSV Sorted by Age");
            WriteObjectsToCSV(students);
            PrintCSV();
        }

        // Write Objects Back to CSV
        static void WriteObjectsToCSV(List<Student> students)
        {
            using (StreamWriter writer = new StreamWriter(path))
            {
                writer.WriteLine("Id,Name,Age");
                foreach (var s in students)
                    writer.WriteLine($"{s.Id},{s.Name},{s.Age}");
            }
        }

        // Count Records
        static void CountStudents(List<Student> students)
        {
            Console.WriteLine("Total Records: " + students.Count + "\n");
        }

        public static void Main()
        {
            CreateCSV();

            AppendStudent(new Student { Id = 4, Name = "Sneha", Age = 23 });

            List<Student> students = ReadCsvAsObjects();

            ValidateCSV(students);
            SearchStudent(students, "Dilshad");

            UpdateStudent(students, "Dilshad", 22);

            DeleteStudent(students, "Aman");

            SortByAge(students);

            CountStudents(students);
        }
    }
}
