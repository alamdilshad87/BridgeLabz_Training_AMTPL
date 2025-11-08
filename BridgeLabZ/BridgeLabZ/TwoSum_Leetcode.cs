using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabZ
{
    internal class TwoSum_Leetcode
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
            TwoSum_Leetcode solution = new TwoSum_Leetcode();
            int[] nums = { 2, 7, 11, 15 };
            int target = 9;
            int[] result = solution.TwoSum(nums, target);
            Console.WriteLine($"Indices: [{result[0]}, {result[1]}]");
        }
    }
}
