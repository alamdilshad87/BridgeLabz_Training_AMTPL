using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabZ.GenericCollections._2_Dictionary
{
    internal class Dictionary_Functions
    {
        static void Main()
        {
            Dictionary<int, string> dict = new Dictionary<int, string>();

            dict.Add(1, "Dilshad");
            dict.Add(2, "Om");
            dict.Add(3, "Sudipta");
            Console.WriteLine("Dictionary after Add:");
            foreach (var kv in dict)
                Console.WriteLine(kv.Key + " : " + kv.Value);
            dict.Remove(2);
            Console.WriteLine("Dictionary after Remove(2):");
            foreach (var kv in dict)
                Console.WriteLine(kv.Key + " : " + kv.Value);

            Console.WriteLine("ContainsKey(1): " + dict.ContainsKey(1));
            Console.WriteLine("ContainsValue(\"Om\"): " + dict.ContainsValue("Om"));
            Console.WriteLine("Keys:");
            foreach (var k in dict.Keys)
                Console.WriteLine(k);

            Console.WriteLine("Values:");
            foreach (var v in dict.Values)
                Console.WriteLine(v);

            Console.WriteLine("Count: " + dict.Count);

            Console.WriteLine("All Key-Value Pairs:");
            foreach (var kv in dict)
                Console.WriteLine(kv.Key + " : " + kv.Value);

            dict.Clear();
            Console.WriteLine("Count after Clear: " + dict.Count);
        }
    }
}