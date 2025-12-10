using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabZ.Closures
{
    internal class MultipleFnClosures
    {
        public static void Main()
        {
            Func<Func<int>> CreateCounter = () =>
            {
                int count = 0;

                return () =>
                {
                    count++;
                    return count;
                };
            };

            var counter1 = CreateCounter();
            var counter2 = CreateCounter();

            Console.WriteLine(counter1());
            Console.WriteLine(counter1());
            Console.WriteLine(counter2());

        }
    }
}
