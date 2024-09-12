using LeetCode.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.CSharp
{
    internal class Solution1877 : IRunProgram
    {
        public void Run()
        {
            MinPairSum([3, 5, 2, 3]).Print();
        }

        public int MinPairSum(int[] nums)
        {
            Array.Sort(nums);

            int max = int.MinValue;
            int left = 0;
            int right = nums.Length - 1;

            while (left < right)
            {
                max = Math.Max(max, nums[left] + nums[right]);
                left++;
                right--;
            }


            return max;
        }
    }
}
