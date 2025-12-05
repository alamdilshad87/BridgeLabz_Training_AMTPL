using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabZ.GenericCollections._1_List
{
    internal class SimpleList
    {
        static void Main()
        {
            List<int> list = new List<int>();

            list.Add(10);
            list.Add(20);
            list.Add(30);

            foreach (int item in list)
                Console.WriteLine(item);

        }
    }
}