using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabZ.NonGenericCollections._5_Queue
{
    internal class SimpleQueue
    {
        public static void Main()
        {
            Queue queue = new Queue();
            queue.Enqueue(10);
            queue.Enqueue("Dilshad");
            queue.Enqueue(20.5);

            Console.WriteLine("Queue Elements:");
            foreach (var item in queue)
                Console.WriteLine(item);

            Console.WriteLine("Peek: " + queue.Peek());
            Console.WriteLine("Dequeue: " + queue.Dequeue());

            Console.WriteLine("After Dequeue:");
            foreach (var item in queue)
                Console.WriteLine(item);
        }
    }
}