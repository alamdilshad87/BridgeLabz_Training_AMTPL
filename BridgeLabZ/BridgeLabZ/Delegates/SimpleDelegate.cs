using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabZ.Delegates
{
    internal class SimpleDelegate
    {
        public delegate int MathOp(int a, int b);
        public static int Add(int x, int y) => x + y;
        static int Sub(int x, int y) => x - y;
        static int Mult(int x, int y) => x * y;
        static int Div(int x, int y) => x / y;
        
        public static void Main()
        {
            MathOp op = Add;
            Console.WriteLine("Add:" + op(10, 5));
            op = Sub;
            Console.WriteLine("Sub:" + op(10, 5));
            op = Mult;
            Console.WriteLine("Mult:" + op(10, 5));
            op = Div;
            Console.WriteLine("Div:" + op(10, 5));
        }
    }
}
