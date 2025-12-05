using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabZ.Problems
{
    internal class DecimalToBinary
    {
        static void Main()
        {
            int num = 19;
            Stack<int> stack = new Stack<int>();
            while (num > 0)
            {
                stack.Push(num % 2);
                num /= 2;
            }
            while (stack.Count > 0)
                Console.Write(stack.Pop());
        }
    }
}