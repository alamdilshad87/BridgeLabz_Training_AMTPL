using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabZ.Problems
{
    internal class RemoveDuplicate_HashSet
    {
        static void Main()
        {
            int[] arr = { 1, 2, 2, 3, 3, 4, 4, 4 };
            HashSet<int> set = new HashSet<int>(arr);
            Console.WriteLine(string.Join(" ", set));
        }
    }
}