using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabZ.Delegates.SingleCast
{
    internal class InvokeMethod
    {
        public delegate int MathOp(int a, int b);
        public static int Add(int x, int y)
        {
            return x + y;
        }
        public static void Main()
        {
            MathOp del = Add;
            int result = del.Invoke(20, 10);

            Console.WriteLine("Invoke() Result: " + result);
        }
    }
}
