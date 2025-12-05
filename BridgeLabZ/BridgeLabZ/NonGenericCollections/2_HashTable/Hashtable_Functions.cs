using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabZ.NonGenericCollections._2_HashTable
{
    public class Hashtable_Functions
    {
        public static void Main(string[] args)
        {
            Hashtable ht = new Hashtable();

            Console.WriteLine(" Add() ");
            ht.Add(1, "Dilshad");
            ht.Add(2, "Om");
            ht.Add(3, "Sudipta");
            Print(ht);

            Console.WriteLine("\n ContainsKey() ");
            Console.WriteLine("ContainsKey(2): " + ht.ContainsKey(2));

            Console.WriteLine("\n ContainsValue() ");
            Console.WriteLine("ContainsValue(\"Om\"): " + ht.ContainsValue("Om"));

            Console.WriteLine("\n Remove() ");
            ht.Remove(2);
            Print(ht);

            Console.WriteLine("\n Keys Collection ");
            foreach (var key in ht.Keys)
                Console.WriteLine("Key: " + key);

            Console.WriteLine("\n Values Collection ");
            foreach (var val in ht.Values)
                Console.WriteLine("Value: " + val);

            Console.WriteLine("\n Count ");
            Console.WriteLine("Count: " + ht.Count);

            Console.WriteLine("\n Clear() ");
            ht.Clear();
            Console.WriteLine("Count after Clear(): " + ht.Count);

            Console.ReadKey();
        }

        static void Print(Hashtable ht)
        {
            foreach (DictionaryEntry entry in ht)
                Console.WriteLine("Key: " + entry.Key + ", Value: " + entry.Value);
        }
    }
}