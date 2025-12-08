using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabZ._1_Sorting
{
    internal class SelectionSort
    {
        static void Main()
        {
            int[] arr = { 64, 25, 12, 22, 11 };

            for (int i = 0; i < arr.Length; i++)
            {
                int min = i;

                for (int j = i + 1; j < arr.Length; j++)
                    if (arr[j] < arr[min])
                        min = j;

                int temp = arr[min];
                arr[min] = arr[i];
                arr[i] = temp;
            }

            Console.WriteLine(string.Join(" ", arr));
        }
    }
}
