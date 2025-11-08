using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabZ.ObjectsAndClasses
{
    internal class ObjectWithMethods
    {
        public int id;
        public string name;
        public double salary;

        public void SetDetails(int id, string name, double salary)
        {
            this.id = id;
            this.name = name;
            this.salary = salary;
        }

        public void Display()
        {
            Console.WriteLine($"ID: {id}\n Name: {name}\n Salary: Rs.{salary}\n");
        }
        public static void Main()
        {
            ObjectWithMethods emp = new ObjectWithMethods();
            emp.SetDetails(101, "Dilshad", 50000);
            emp.Display();
        }
    }
}
