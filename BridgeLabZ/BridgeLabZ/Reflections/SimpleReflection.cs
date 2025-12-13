using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace BridgeLabZ.Reflections
{
    internal class SimpleReflection
    {
        class Student
        {
            public string Name { get; set; }
            public void Study() => Console.WriteLine("Studying");
        }

        class Program
        {
            public static void Main()
            {
                Type t = typeof(Student);
                Console.WriteLine("Class Name:" + t.Name);
                Console.WriteLine("Properties");
                foreach (var p in t.GetProperties())
                    Console.WriteLine(p.Name);

                Console.WriteLine("Methods:");
                foreach (var m in t.GetMethods())
                    Console.WriteLine(m.Name);
            }
        }
    }
}