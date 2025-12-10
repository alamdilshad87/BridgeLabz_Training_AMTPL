using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabZ.Delegates.SingleCast
{
    internal class AnonymousMethod
    {
        public delegate int MathOp(int ab, int b);
        public static void Main()
        {
            MathOp op = delegate (int x, int y)
            {
                return x * y;
            };
            Console.WriteLine("Anonymous Multiplication: " + op(10, 5));
        }
    }
}
