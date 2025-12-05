using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabZ.GenericCollections._6_SortedSet
{
    internal class SimpleSortedSet
    {
        static void Main()
        {
            SortedSet<int> ss = new SortedSet<int>();

            ss.Add(30);
            ss.Add(10);
            ss.Add(20);
            ss.Add(20);   // duplicate ignored
            ss.Add(40);

            foreach (var item in ss)
                Console.WriteLine(item);
        }
    }
}
