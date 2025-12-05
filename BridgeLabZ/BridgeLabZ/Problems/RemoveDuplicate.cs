using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabZ.Problems
{
    internal class RemoveDuplicate
    {
        static void Main()
        {
            List<int> list = new List<int> { 1, 1, 2, 2, 3, 3, 3, 4 };

            List<int> result = new List<int>();
            result.Add(list[0]);

            for (int i = 1; i < list.Count; i++)
            {
                if (list[i] != list[i - 1])
                    result.Add(list[i]);
            }

            Console.WriteLine(string.Join(" ", result));
        }
    }
}