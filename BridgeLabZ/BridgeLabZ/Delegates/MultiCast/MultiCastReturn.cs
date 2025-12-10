using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabZ.Delegates.MultiCast
{
    internal class MultiCastReturn
    {
        public delegate int MathOp(int a, int b);
        public static int Add(int x, int y)
        {
            Console.WriteLine("Add Executed");
            return x + y;
        }
        public static int Sub(int x, int y)
        {
            Console.WriteLine("Sub Executed");
            return x - y;
        }
        public static void Main()
        {
            MathOp op = Add;
            op += Sub;
            Console.WriteLine("\nFinal Returned Value: " + op(10, 5));
        }
    }
}