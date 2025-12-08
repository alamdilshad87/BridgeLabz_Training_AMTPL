using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabZ._2_Searching
{
    internal class LinearSearch
    {
        static void Main()
        {
            int[] arr = { 10, 20, 30, 40, 50 };
            int target = 30;

            for (int i = 0; i < arr.Length; i++)
                if (arr[i] == target)
                    Console.WriteLine("Found at index " + i);
        }
    }
}
