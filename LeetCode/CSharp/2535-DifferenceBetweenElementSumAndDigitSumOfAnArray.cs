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
    internal class Solution2535 : IRunProgram
    {
        public void Run()
        {
            DifferenceOfSum([1, 15, 6, 3]).Print();
        }
        public int DifferenceOfSum(int[] nums)
        {
            int total = 0;
            int digits = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] == 0)
                {
                    continue;
                }

                total += nums[i];
                digits += Dig(nums[i]);
            }

            return Math.Abs(total - digits);
        }

        private int Dig(int input)
        {
            int output = 0;
            while (input > 0)
            {
                output += input % 10;
                input /= 10;
            }
            return output;
        }
    }
}