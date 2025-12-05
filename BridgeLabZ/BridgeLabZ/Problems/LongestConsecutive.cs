using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabZ.Problems
{
    internal class LongestConsecutive
    {
        static void Main()
        {
            int[] arr = { 100,200, 1, 3, 2 };
            HashSet<int> set = new HashSet<int>(arr);
            int longest = 0;
            foreach (int num in set)
            {
                if (!set.Contains(num - 1))
                {
                    int curr = num;
                    int length = 1;
                    while (set.Contains(curr + 1))
                    {
                        curr++;
                        length++;
                    }
                    longest = Math.Max(longest, length);
                }
            }
            Console.WriteLine(longest);
        }
    }
}