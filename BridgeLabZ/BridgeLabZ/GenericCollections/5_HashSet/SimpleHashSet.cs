using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabZ.GenericCollections._5_HashSet
{
    internal class SimpleHashSet
    {
        static void Main()
        {
            HashSet<int> hs = new HashSet<int>();

            hs.Add(10);
            hs.Add(20);
            hs.Add(20);  // duplicate, ignored
            hs.Add(30);

            foreach (var item in hs)
                Console.WriteLine(item);
        }
    }
}
