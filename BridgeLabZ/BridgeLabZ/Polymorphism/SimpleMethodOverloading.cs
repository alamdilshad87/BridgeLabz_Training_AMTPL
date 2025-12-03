using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace BridgeLabZ.Polymorphism
{
    internal class SimpleMethodOverloading
    {
        public void Add(int a, int b)
        {
            Console.WriteLine(a + b);
        }
        public void Add(float x, float y)
        {
            Console.WriteLine(x + y);
        }
        public void Add(string s1, string s2)
        {
            Console.WriteLine(s1 + " " + s2);
        }
        public static void Main(string[] args)
        {
            SimpleMethodOverloading obj = new SimpleMethodOverloading();

            obj.Add(10, 20);
            obj.Add(10.7f, 20.5f);
            obj.Add("Dilshad", "Alam");

            Console.ReadKey();
        }
    }
}
