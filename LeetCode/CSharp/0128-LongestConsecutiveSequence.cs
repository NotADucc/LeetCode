﻿using LeetCode.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace LeetCode.CSharp
{
    internal class Solution0128 : IRunProgram
    {
        public void Run()
        {
            LongestConsecutive([100, 4, 200, 1, 3, 2]).Print();
            LongestConsecutive([0, 3, 7, 2, 5, 8, 4, 6, 0, 1]).Print();
        }
        public int LongestConsecutive(int[] nums)
        {
            Array.Sort(nums);

            int streak = 1, max = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                if (i + 1 >= nums.Length)
                {
                    max = Math.Max(max, nums.Length - i);
                }
                else if (nums[i + 1] - 1 == nums[i])
                {
                    streak++;
                    max = Math.Max(max, streak);
                }
                else if (nums[i + 1] == nums[i]) { }
                else
                {
                    streak = 1;
                }
            }

            return max;
        }
    }
}