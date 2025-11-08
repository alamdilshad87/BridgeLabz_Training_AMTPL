using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabZ
{
    internal class ImplicitConversion
    {
        public static void Main(string[] args)
        {
            int num = 25;
            double result;
            result = num;

            Console.WriteLine("Integer value: " + num);
            Console.WriteLine("Double value (after implicit conversion): " + result);
        }
    }
}
