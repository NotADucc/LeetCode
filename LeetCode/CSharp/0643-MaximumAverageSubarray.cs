using LeetCode.CSharp.Shared;
using LeetCode.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace LeetCode.CSharp
{
    internal class Solution0643 : IRunProgram
    {
        public void Run()
        {
            FindMaxAverage([1, 12, -5, -6, 50, 3], 4).Print();
            FindMaxAverage([5], 1).Print();
        }
        public double FindMaxAverage(int[] nums, int k)
        {
            double highest = 0;
            int i = 0;

            while (i < k)
            {
                highest += nums[i];
                i++;
            }

            double current = highest;
            while (i < nums.Length)
            {
                current = current - nums[i - k] + nums[i];
                highest = Math.Max(highest, current);
                i++;
            }

            return highest / k;
        }
    }
}
