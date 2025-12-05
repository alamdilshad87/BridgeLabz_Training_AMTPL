using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabZ.GenericCollections._9_Queue
{
    internal class Queue_Functions
    {
        static void Main()
        {
            Queue<int> queue = new Queue<int>();

            queue.Enqueue(10);
            queue.Enqueue(20);
            queue.Enqueue(30);

            Console.WriteLine("Queue Elements:");
            foreach (var item in queue)
                Console.WriteLine(item);

            Console.WriteLine("\nPeek: " + queue.Peek());

            Console.WriteLine("Dequeue: " + queue.Dequeue());

            Console.WriteLine("\nAfter Dequeue:");
            foreach (var item in queue)
                Console.WriteLine(item);

            Console.WriteLine("\nContains 20: " + queue.Contains(20));

            Console.WriteLine("Count: " + queue.Count);

            queue.Clear();
            Console.WriteLine("Count after Clear: " + queue.Count);
        }
    }
}

