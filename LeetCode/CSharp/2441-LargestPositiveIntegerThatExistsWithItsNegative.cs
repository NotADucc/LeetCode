﻿using LeetCode.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.CSharp
{
    internal class Solution2441 : IRunProgram
    {
        public void Run()
        {
            FindMaxK([-1, 2, -3, 3]).Print();
        }
        public int FindMaxK(int[] nums)
        {
            Array.Sort(nums);
            int left = 0, right = nums.Length - 1;

            while (left < right)
            {
                int lVal = nums[left] * -1;
                int rVal = nums[right];
                if (lVal == rVal)
                {
                    return rVal;
                }

                if (lVal < rVal)
                {
                    right--;
                }
                else
                {
                    left++;
                }
            }

            return -1;
        }
    }
}