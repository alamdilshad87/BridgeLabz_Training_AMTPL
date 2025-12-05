using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabZ.Problems
{
    internal class LargestSubArray
    {
        static void Main()
        {
            int[] arr = { 0, 1, 0, 1, 1, 0, 0 };

            Dictionary<int, int> map = new Dictionary<int, int>();
            map[0] = -1;

            int prefix = 0, maxLen = 0, start = 0, end = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                prefix += (arr[i] == 0 ? -1 : 1);

                if (map.ContainsKey(prefix))
                {
                    int len = i - map[prefix];
                    if (len > maxLen)
                    {
                        maxLen = len;
                        start = map[prefix] + 1;
                        end = i;
                    }
                }
                else
                    map[prefix] = i;
            }

            Console.WriteLine($"Length: {maxLen}, Start: {start}, End: {end}");
        }
    }
}
