using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabZ.Constructor.TypesOfConstructor
{
    internal class StaticConstructor
    {
        public static string CompanyName;
        public int Id;
        public string Name;
        static StaticConstructor()
        {
            CompanyName = "BridgeLabZ";
            Console.WriteLine("Static Constructor called.");
        }
        public StaticConstructor(int id, string name)
        {
            Id = id;
            Name = name;
            Console.WriteLine("Instance Constructor called.");
        }

        public void Display()
        {
            Console.WriteLine($"Company: {CompanyName}\nID: {Id}\n Name: {Name}");
        }
        public static void Main(string[] args)
        {
            StaticConstructor emp1 = new StaticConstructor(917, "Md Dilshad Alam");
            emp1.Display();
            StaticConstructor emp2 = new StaticConstructor(923, "Anupam Dubey");
            emp2.Display();
        }
    }
}
