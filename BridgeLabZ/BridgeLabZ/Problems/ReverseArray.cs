using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabZ.Problems
{
    internal class ReverseArray
    {
        static void Main()
        {
            int[] arr = { 1, 2, 3, 4, 5 };
            int left = 0, right = arr.Length - 1;
            while (left < right)
            {
                int temp = arr[left];
                arr[left] = arr[right];
                arr[right] = temp;

                left++;
                right--;
            }

            Console.WriteLine(string.Join(" ", arr));
        }
    }
}
