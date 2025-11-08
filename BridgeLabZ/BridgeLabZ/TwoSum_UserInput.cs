using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabZ
{
    internal class TwoSum_UserInput
    {
        public int[] TwoSum(int[] nums, int target)
        {
            int n = nums.Length;

            for (int i = 0; i < n; i++)
            {
                for (int j = i + 1; j < n; j++)
                {
                    if (nums[i] + nums[j] == target)
                    {
                        return new int[] { i, j };
                    }
                }
            }
            return new int[] { };
        }

        public static void Main(string[] args)
        {
            TwoSum_UserInput solution = new TwoSum_UserInput();
            Console.WriteLine("Enter the size of the array:");
            int size = Convert.ToInt32(Console.ReadLine());
            int[] nums = new int[size];

            Console.WriteLine("Enter the elements of the array:");
            for (int i = 0; i < size; i++)
            {
                Console.Write($"Element {i + 1}: ");
                nums[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("Enter the target:");
            int target = Convert.ToInt32(Console.ReadLine());

            int[] result = solution.TwoSum(nums, target);
            Console.WriteLine($"Indices: [{result[0]}, {result[1]}]");
        }
    }
}
