using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabZ.GenericCollections._4_SortedDictionary
{
    internal class SortedDictionary_Functions
    {
        static void Main()
        {
            SortedDictionary<int, string> sd = new SortedDictionary<int, string>();

            sd.Add(4, "Four");
            sd.Add(1, "One");
            sd.Add(3, "Three");
            sd.Add(2, "Two");

            Console.WriteLine("All Key-Value Pairs:");
            foreach (var kv in sd)
                Console.WriteLine(kv.Key + " : " + kv.Value);

            Console.WriteLine("\nContainsKey(3): " + sd.ContainsKey(3));
            Console.WriteLine("ContainsValue(\"Two\"): " + sd.ContainsValue("Two"));

            Console.WriteLine("\nRemove key 1");
            sd.Remove(1);

            Console.WriteLine("\nKeys:");
            foreach (var key in sd.Keys)
                Console.WriteLine(key);

            Console.WriteLine("\nValues:");
            foreach (var val in sd.Values)
                Console.WriteLine(val);

            Console.WriteLine("\nCount: " + sd.Count);

            sd.Clear();
            Console.WriteLine("Count after Clear: " + sd.Count);
        }
    }
}