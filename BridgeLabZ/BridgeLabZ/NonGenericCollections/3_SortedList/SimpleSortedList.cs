using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabZ.NonGenericCollections._3_SortedList
{
    public class SimpleSortedList
    {
        public static void Main(string[] args)
        {
            SortedList sortedList = new SortedList();
            sortedList.Add(3, "Three");
            sortedList.Add(1, "One");
            sortedList.Add(2, "Two");
            Console.WriteLine("SortedList contents (key-value pairs):");
            foreach (DictionaryEntry entry in sortedList)
            {
                Console.WriteLine($"Key: {entry.Key}, Value: {entry.Value}");
            }
        }
    }
}
