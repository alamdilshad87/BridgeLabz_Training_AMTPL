using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabZ.NonGenericCollections._3_SortedList
{
    internal class SortedList_Functions
    {
        public static void Main()
        {
            SortedList sl = new SortedList();

            sl.Add(3, "Three");
            sl.Add(1, "One");
            sl.Add(2, "Two");
            sl.Add(5, "Five");
            sl.Add(4, "Four");

            Console.WriteLine("All Keys and Values:");
            foreach (DictionaryEntry d in sl)
                Console.WriteLine($"{d.Key} : {d.Value}");

            Console.WriteLine("\nContainsKey(3): " + sl.ContainsKey(3));
            Console.WriteLine("ContainsValue(\"Four\"): " + sl.ContainsValue("Four"));

            Console.WriteLine("\nValue at index 1: " + sl.GetByIndex(1));
            Console.WriteLine("Key at index 2: " + sl.GetKey(2));

            sl.Remove(5);
            sl.RemoveAt(0);

            Console.WriteLine("\nAfter Removals:");
            foreach (DictionaryEntry d in sl)
                Console.WriteLine($"{d.Key} : {d.Value}");

            Console.ReadKey();
        }
    }
}