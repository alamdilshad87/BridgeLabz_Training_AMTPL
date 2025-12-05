using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabZ.NonGenericCollections._4_Stack
{
    internal class SimpleStack
    {
        public static void Main()
        {
            Stack stack = new Stack();
            stack.Push(10);
            stack.Push("Dilshad");
            stack.Push(20.5);

            Console.WriteLine("Stack Elements:");
            foreach (var item in stack)
                Console.WriteLine(item);

            Console.WriteLine("Peek: " + stack.Peek());
            Console.WriteLine("Pop: " + stack.Pop());

            Console.WriteLine("After Pop:");
            foreach (var item in stack)
                Console.WriteLine(item);
        }
    }
}
