using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace BridgeLabZ.File_IO
{
    internal class Students
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
    }
    internal class FileJSON
    {
        public static void Main()
        {
            string path = "student.json";

            // Create object
            Students student = new Students
            {
                Id = 1,
                Name = "Dilshad",
                Age = 21
            };

            // Write JSON to file
            string jsonWrite = JsonSerializer.Serialize(student, new JsonSerializerOptions
            {
                WriteIndented = true
            });

            File.WriteAllText(path, jsonWrite);
            Console.WriteLine("JSON Written to File:\n");
            Console.WriteLine(jsonWrite);

            // Read JSON from file
            string jsonRead = File.ReadAllText(path);
            Student readStudent = JsonSerializer.Deserialize<Student>(jsonRead);

            Console.WriteLine("\nJSON Read from File:");
            Console.WriteLine($"Id: {readStudent.Id}");
            Console.WriteLine($"Name: {readStudent.Name}");
            Console.WriteLine($"Age: {readStudent.Age}");
        }
    }
}