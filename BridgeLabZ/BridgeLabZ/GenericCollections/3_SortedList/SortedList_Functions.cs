using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabZ.GenericCollections._3_SortedList
{
    internal class SortedList_Functions
    {
        static void Main()
        {
            SortedList<int, string> sl = new SortedList<int, string>();

            sl.Add(3, "Three");
            sl.Add(1, "One");
            sl.Add(2, "Two");
            sl.Add(5, "Five");
            sl.Add(4, "Four");

            Console.WriteLine("All Key-Value Pairs:");
            foreach (var kv in sl)
                Console.WriteLine(kv.Key + " : " + kv.Value);

            Console.WriteLine("\nContainsKey(3): " + sl.ContainsKey(3));
            Console.WriteLine("ContainsValue(\"Four\"): " + sl.ContainsValue("Four"));

            Console.WriteLine("\nIndex of Key 2: " + sl.IndexOfKey(2));
            Console.WriteLine("Index of Value 'Three': " + sl.IndexOfValue("Three"));

            Console.WriteLine("\nRemove(key): Removing key 5");
            sl.Remove(5);

            Console.WriteLine("RemoveAt(index): Removing index 0");
            sl.RemoveAt(0);

            Console.WriteLine("\nKeys:");
            foreach (var key in sl.Keys)
                Console.WriteLine(key);

            Console.WriteLine("\nValues:");
            foreach (var value in sl.Values)
                Console.WriteLine(value);

            Console.WriteLine("\nCount: " + sl.Count);
            foreach (var kv in sl)
                Console.WriteLine(kv.Key + " : " + kv.Value);
            sl.Clear();
            Console.WriteLine("Count after Clear: " + sl.Count);

        }
    }
}