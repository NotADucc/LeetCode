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
    internal class Solution2044 : IRunProgram
    {
        public void Run()
        {
            CountMaxOrSubsets([3, 1]).Print();
            CountMaxOrSubsets([2, 2, 2]).Print();
        }
        public int CountMaxOrSubsets(int[] nums)
        {
            int max_index = 0, max = nums[0];
            Helper(ref max, nums, 0, ref max_index, 0);
            return max_index;
        }

        private void Helper(ref int max, int[] nums, int current_or, ref int max_count, int current_index)
        {
            for (int i = current_index; i < nums.Length; i++)
            {
                int or = current_or | nums[i];
                if (or > max)
                {
                    max = or;
                    max_count = 1;
                }
                else if (or == max)
                {
                    max_count++;
                }
                Helper(ref max, nums, or, ref max_count, i + 1);
            }
        }
    }
}
