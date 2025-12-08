using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabZ._2_Searching
{
    internal class BinarySearch
    {
        static int BS(int[] arr, int target)
        {
            int left = 0, right = arr.Length - 1;

            while (left <= right)
            {
                int mid = (left + right) / 2;

                if (arr[mid] == target) return mid;
                else if (arr[mid] < target) left = mid + 1;
                else right = mid - 1;
            }
            return -1;
        }

        static void Main()
        {
            int[] arr = { 10, 20, 30, 40, 50 };
            Console.WriteLine(BS(arr, 30));
        }
    }
}
