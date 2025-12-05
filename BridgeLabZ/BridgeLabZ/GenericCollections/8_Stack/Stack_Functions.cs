using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabZ.GenericCollections._8_Stack
{
    internal class Stack_Functions
    {
        static void Main()
        {
            Stack<int> stack = new Stack<int>();

            stack.Push(10);
            stack.Push(20);
            stack.Push(30);

            Console.WriteLine("Stack Elements:");
            foreach (var item in stack)
                Console.WriteLine(item);

            Console.WriteLine("\nPeek: " + stack.Peek());

            Console.WriteLine("Pop: " + stack.Pop());

            Console.WriteLine("\nAfter Pop:");
            foreach (var item in stack)
                Console.WriteLine(item);

            Console.WriteLine("\nContains 20: " + stack.Contains(20));

            Console.WriteLine("Count: " + stack.Count);

            stack.Clear();
            Console.WriteLine("Count after Clear: " + stack.Count);
        }
    }
}
