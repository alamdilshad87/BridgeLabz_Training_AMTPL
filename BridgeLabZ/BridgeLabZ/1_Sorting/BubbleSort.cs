using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabZ._1_Sorting
{
    internal class BubbleSort
    {
        static void Main()
        {
            int[] arr = { 5, 3, 8, 4, 2 };

            for (int i = 0; i < arr.Length - 1; i++)
                for (int j = 0; j < arr.Length - i - 1; j++)
                    if (arr[j] > arr[j + 1])
                    {
                        int temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }

            Console.WriteLine(string.Join(" ", arr));
        }
    }
}