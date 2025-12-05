using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabZ.GenericCollections._7_LinkedList
{
    internal class LinkedList_Functions
    {
        static void Main()
        {
            LinkedList<int> list = new LinkedList<int>();

            list.AddFirst(20);
            list.AddLast(40);
            list.AddLast(60);

            var node40 = list.Find(40);
            list.AddBefore(node40, 30);

            list.AddAfter(node40, 50);

            Console.WriteLine("Initial LinkedList:");
            foreach (var item in list)
                Console.WriteLine(item);

            Console.WriteLine("\nContains 30: " + list.Contains(30));

            list.Remove(40);
            list.RemoveFirst();
            list.RemoveLast();

            Console.WriteLine("\nAfter Removes:");
            foreach (var item in list)
                Console.WriteLine(item);

            Console.WriteLine("\nCount: " + list.Count);

            list.Clear();
            Console.WriteLine("Count after Clear: " + list.Count);
        }
    }
}
