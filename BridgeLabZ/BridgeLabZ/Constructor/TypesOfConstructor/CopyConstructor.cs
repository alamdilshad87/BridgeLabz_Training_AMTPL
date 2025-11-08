using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabZ.Constructor.TypesOfConstructor
{
    internal class CopyConstructor
    {
        public int Id;
        public string Name;
        public CopyConstructor(int id, string name)
        {
            Id = id;
            Name = name;
        }
        public CopyConstructor(CopyConstructor emp)
        {
            Id = emp.Id;
            Name = emp.Name;
        }

        public void Display()
        {
            Console.WriteLine($"Copied Employee ID: {Id}\n Name: {Name}");
        }
        public static void Main(string[] args)
        {
            CopyConstructor emp1 = new CopyConstructor(101, "Md Dilshad Alam");
            CopyConstructor emp2 = new CopyConstructor(emp1);
            emp2.Display();
        }
    }
}
