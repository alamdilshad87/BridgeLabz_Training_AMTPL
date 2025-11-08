using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabZ
{
    internal class Top10AvgSum
    {
        static void Main()
        {
            int sum = 0, avg = 0;
            for (int i = 0; i < 10; i++)
            {
                sum += i;
            }

            double average = (double)sum / 10;
            Console.WriteLine($"Sum: {sum}");
            Console.WriteLine($"Average: {average:F2}");
        }
    }
}