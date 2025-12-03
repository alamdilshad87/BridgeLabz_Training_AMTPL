using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabZ.Polymorphism.CompileTImePolymorphism
{
    class Calculator
    {
        public void Add(int a, int b)
        {
            Console.WriteLine("Sum of integers: " + (a + b));
        }

        public void Add(double a, double b)
        {
            Console.WriteLine("Sum of doubles: " + (a + b));
        }

        public void Add(string a, string b)
        {
            Console.WriteLine("Concatenated string: " + a + " " + b);
        }

        static void Main(string[] args)
        {
            Calculator calc = new Calculator();

            calc.Add(10, 20);
            calc.Add(10.5, 20.5);
            calc.Add("Hello", "World");

            Console.ReadKey();
        }
    }
}