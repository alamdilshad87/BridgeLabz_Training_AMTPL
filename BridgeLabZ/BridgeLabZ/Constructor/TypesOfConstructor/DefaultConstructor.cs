using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabZ.Constructor.TypesOfConstructor
{
    internal class DefaultConstructor
    {
        public int Id;
        public string Name;
        public DefaultConstructor()
        {
            Id = 917;
            Name = "Dilshad";
        }

        public void Display()
        {
            Console.WriteLine($"Student ID: {Id}\nName: {Name}");
        }
        public static void Main(string[] args)
        {
            DefaultConstructor student = new DefaultConstructor();
            student.Display();
        }
    }
}
