using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabZ.Closures
{
    internal class SimpleClosure
    {
        public static void Main()
        {
            int counter = 0;
            Func<int> increment = () =>
            {
                counter++;
                return counter;
            };

            Console.WriteLine(increment());
            Console.WriteLine(increment());
            Console.WriteLine(increment());
        }
    }
}