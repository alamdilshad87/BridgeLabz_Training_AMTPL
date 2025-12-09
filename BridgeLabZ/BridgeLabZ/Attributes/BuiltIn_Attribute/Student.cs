using System;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Runtime.InteropServices;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace BridgeLabZ.Attributes.BuiltIn_Attribute
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        [JsonIgnore]
        public string Password;
    }

    public class OldFeatures
    {
        [Obsolete("Use NewMethod() instead. This method is outdated.")]
        public void OldMethod()
        {
            Console.WriteLine("Old method executed");
        }
        public void NewMethod()
        {
            Console.WriteLine("New method executed");
        }
    }

    public class Logger
    {
        [Conditional("DEBUG")]
        public static void DebugLog(string msg)
        {
            Console.WriteLine("[DEBUG] " + msg);
        }
    }
    public class MathOps
    {
        [DebuggerStepThrough]
        public int Add(int a, int b) => a + b;
    }
    public class Config
    {
        [DefaultValue("light")]
        public string Theme { get; set; }
    }
    class Program
    {
        static void Main()
        {
            Console.WriteLine("=== Built-In Attribute Demonstration ===");
            Student s = new Student { Id = 1, Name = "Rahul", Password = "secret123" };
            
            string json = JsonSerializer.Serialize(s, new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText("student.json", json);
            Console.WriteLine("Student object serialized to student.json (password skipped).");

            OldFeatures f = new OldFeatures();
            f.OldMethod();
            f.NewMethod();

            Logger.DebugLog("This will print only in DEBUG mode");

            MathOps ops = new MathOps();
            Console.WriteLine("Add Result = " + ops.Add(5, 3));

            Config cfg = new Config();
            Console.WriteLine("Default Theme (from attribute) = light");
        }
    }
}
