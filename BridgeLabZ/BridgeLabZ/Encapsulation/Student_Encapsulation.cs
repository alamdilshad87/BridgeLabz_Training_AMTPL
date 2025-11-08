using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabZ.Encapsulation
{
    internal class Student_Encapsulation
    {
        private string name;
        public void SetName(string n)
        {
            name = n;
        }
        public string GetName()
        {
            return name;
        }
        static void Main()
        {
            Student_Encapsulation s = new Student_Encapsulation();
            s.SetName("Dilshad");
            Console.WriteLine("Student Name: " + s.GetName());
        }
    }
}
