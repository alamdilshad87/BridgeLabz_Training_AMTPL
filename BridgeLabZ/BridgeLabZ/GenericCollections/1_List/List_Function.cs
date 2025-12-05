using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabZ.GenericCollections._1_List
{
    internal class List_Function
    {
        static void Main()
        {
            List<int> list = new List<int>();

            list.Add(10);
            list.Add(30);
            list.Add(50);
            Console.WriteLine("List Elements after Add:");
            foreach (var item in list)
                Console.WriteLine(item);
            list.AddRange(new int[] { 5, 15, 25 });
            Console.WriteLine("List Elements after AddRange:");
            foreach (var item in list)
                Console.WriteLine(item);
            list.Insert(1, 20);
            Console.WriteLine("List Elements after Insert:");
            foreach (var item in list)
                Console.WriteLine(item);
            list.Remove(30);
            list.RemoveAt(0);
            Console.WriteLine("List Elements after Remove and RemoveAt:");
            foreach (var item in list)
                Console.WriteLine(item);
            Console.WriteLine("Contains 50: " + list.Contains(50));
            Console.WriteLine("Index of 25: " + list.IndexOf(25));
            list.Sort();
            list.Reverse();
            Console.WriteLine("List Elements After Sorting and Reversing:");
            foreach (var item in list)
                Console.WriteLine(item);

            Console.WriteLine("Count: " + list.Count);
            list.Clear();
            Console.WriteLine("Count after Clear: " + list.Count);
        }
    }
}
