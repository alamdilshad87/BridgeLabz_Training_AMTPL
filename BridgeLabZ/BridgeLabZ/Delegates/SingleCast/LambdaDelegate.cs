using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabZ.Delegates.SingleCast
{
    internal class LambdaDelegate
    {
        public delegate int MathOp(int a, int b);
        public static void Main()
        {
            MathOp op = (x, y) => x * y;
            Console.WriteLine("Lambda Multiplication :" + op(10, 5));
        }
    }
}
