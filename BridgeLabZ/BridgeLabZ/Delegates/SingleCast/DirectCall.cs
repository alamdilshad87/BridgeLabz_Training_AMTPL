using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabZ.Delegates.SingleCast
{
    internal class DirectCall
    {
        public delegate int MathOp(int a, int b);
        public static int Add(int x, int y)
        {
            return x + y;
        }
        public static void Main()
        {
            MathOp del = Add;
            int result = del(10, 5);

            Console.WriteLine("Direct Invoke Result: " + result);
        }
    }
}
