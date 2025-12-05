using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabZ.Problems
{
    internal class QueueUsingStacks
    {
        Stack<int> s1 = new Stack<int>();
        Stack<int> s2 = new Stack<int>();

        public void Enqueue(int x)
        {
            s1.Push(x);
        }

        public int Dequeue()
        {
            if (s2.Count == 0)
                while (s1.Count > 0)
                    s2.Push(s1.Pop());

            return s2.Pop();
        }
        public int Peek()
        {
            if (s2.Count == 0)
                while (s1.Count > 0)
                    s2.Push(s1.Pop());

            return s2.Peek();
        }
        static void Main()
        {
            QueueUsingStacks q = new QueueUsingStacks();
            q.Enqueue(10);
            q.Enqueue(20);
            q.Enqueue(30);

            Console.WriteLine(q.Dequeue());
            Console.WriteLine(q.Peek());
        }
    }
}
