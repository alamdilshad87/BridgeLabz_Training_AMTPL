using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabZ.Lambdas
{
    internal class SimpleLambda
    {
        public static void Main()
        {
            Func<int, int> square = x => x * x;
            Console.WriteLine("Square of 5: " + square(5));

            Func<int, int, int> add = (a, b) => a + b;
            Console.WriteLine("3 + 4 = " + add(3, 4));

            List<int> numbers = new List<int>() { 5, 10, 15, 20 };
            var filtered = numbers.Where(n => n > 10);

            Console.WriteLine("Numbers greater than 10:");
            foreach (var n in filtered)
            {
                Console.WriteLine(n);
            }
        }
    }
}