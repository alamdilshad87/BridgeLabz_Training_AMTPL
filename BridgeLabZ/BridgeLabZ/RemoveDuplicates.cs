using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabZ
{
    internal class RemoveDuplicates
    {
        public static void Main()
        {
            Console.Write("Enter length of Array: ");
            int size = Convert.ToInt32(Console.ReadLine());
            int[] nums = new int[size];
            Console.WriteLine("Enter elements of Array:");
            for (int i = 0; i < size; i++)
                nums[i] = Convert.ToInt32(Console.ReadLine());
            Array.Sort(nums);
            int index = 0;
            for (int j = 1; j < nums.Length; j++)
            {
                if (nums[j] != nums[index])
                {
                    index++;
                    nums[index] = nums[j];
                }
            }
            Console.WriteLine("\nArray after removing duplicates:");
            for (int k = 0; k <= index; k++)
            {
                Console.Write(nums[k] + " ");
            }
        }
    }
}
