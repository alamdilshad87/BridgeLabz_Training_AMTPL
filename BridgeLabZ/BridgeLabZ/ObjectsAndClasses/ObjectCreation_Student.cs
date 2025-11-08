using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabZ.ObjectsAndClasses
{
    internal class ObjectCreation_Student
    {
        public string Name;
        public int RollNo;

        public void Show()
        {
            Console.WriteLine($"Name: {Name}\nRoll No: {RollNo}\n");
        }
        public static void Main()
        {
            ObjectCreation_Student s1 = new ObjectCreation_Student();
            s1.Name = "Dilshad";
            s1.RollNo = 917;

            ObjectCreation_Student s2 = new ObjectCreation_Student();
            s2.Name = "Anupam";
            s2.RollNo = 923;

            s1.Show();
            s2.Show();
        }
    }
}
