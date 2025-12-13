using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabZ.Reflections
{
    internal class StudentReflection
    {
        class Student
        {
            public string Name { get; set; }
            public int Age { get; set; }

            public Student() { }
            public Student(string name, int age)
            {
                Name = name;
                Age = age;
            }

            public void Study() => Console.WriteLine($"{Name} is Studying");
            public void ShowDetails() => Console.WriteLine($"Name: {Name}, Age: {Age}");
        }
        public class Program
        {
            public static void Main()
            {
                Type t = typeof(Student);

                Console.WriteLine("Class name: " + t.Name);
                Console.WriteLine("Namespace:" + t.Namespace);

                Console.WriteLine("\nProperties ->");
                foreach (var prop in t.GetProperties())
                {
                    Console.WriteLine($"Property: {prop.Name} ({prop.PropertyType.Name})");
                }

                Console.WriteLine("\nMethods->");
                foreach (var meth in t.GetMethods())
                {
                    Console.WriteLine($"Method: {meth.Name}");
                }

                Console.WriteLine("\nConstructors");
                foreach (var con in t.GetConstructors())
                {
                    Console.WriteLine("Constructor:" + con);
                }

                Console.WriteLine("\nDyanmic Obj Creation");
                object obj = Activator.CreateInstance(t);
                t.GetProperty("Name")!.SetValue(obj, "Dilshad");
                t.GetProperty("Age")!.SetValue(obj, 22);

                MethodInfo studyMethod = t.GetMethod("Study");
                studyMethod.Invoke(obj, null);

                MethodInfo showMethod = t.GetMethod("ShowDetails");
                showMethod.Invoke(obj, null);
            }
        }
    }
}