using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabZ.GenericCollections._5_HashSet
{
    internal class HashSet_Functions
    {
        static void Main()
        {
            HashSet<int> hs = new HashSet<int>();

            hs.Add(10);
            hs.Add(20);
            hs.Add(30);
            hs.Add(20);

            Console.WriteLine("HashSet Elements:");
            foreach (var item in hs)
                Console.WriteLine(item);

            Console.WriteLine("\nContains 20: " + hs.Contains(20));

            hs.Remove(10);

            Console.WriteLine("\nAfter Remove:");
            foreach (var item in hs)
                Console.WriteLine(item);

            HashSet<int> other = new HashSet<int>() { 20, 40, 50 };

            hs.UnionWith(other);

            Console.WriteLine("\nAfter UnionWith:");
            foreach (var item in hs)
                Console.WriteLine(item);

            hs.IntersectWith(new HashSet<int>() { 20, 50 });

            Console.WriteLine("\nAfter IntersectWith:");
            foreach (var item in hs)
                Console.WriteLine(item);

            Console.WriteLine("\nCount: " + hs.Count);

            hs.Clear();
            Console.WriteLine("Count after Clear: " + hs.Count);
        }
    }
}