using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabZ.Constructor.TypesOfConstructor
{
    internal class ParameterizedConstructor
    {
        public int Id;
        public string Name;
        public string Department;
        public ParameterizedConstructor(int id, string name, string dept)
        {
            Id = id;
            Name = name;
            Department = dept;
        }

        public void Display()
        {
            Console.WriteLine($"ID: {Id}\n Name: {Name}\n Department: {Department}\n");
        }
        public static void Main(string[] args)
        {
            ParameterizedConstructor student1 = new ParameterizedConstructor(917, "Md Dilshad Alam", "CSE");
            ParameterizedConstructor student2 = new ParameterizedConstructor(923, "Anupam Dubey", "CSE");
            student1.Display();
            student2.Display();
        }
    }
}
