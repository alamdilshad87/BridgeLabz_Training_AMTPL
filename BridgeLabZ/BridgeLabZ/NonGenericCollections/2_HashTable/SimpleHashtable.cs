using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabZ.NonGenericCollections._2_HashTable
{
    public class SimpleHashtable
    {
        public static void Main(String[] args)
        {
            Hashtable hashtable = new Hashtable();
            hashtable.Add(1, "Dilshad");
            hashtable.Add(2, "Om");
            hashtable.Add(3, "Sudipta");
            foreach (DictionaryEntry i in hashtable)
            {
                Console.WriteLine("Key: " + i.Key + ", Value: " + i.Value);
            }
        }
    }
}
