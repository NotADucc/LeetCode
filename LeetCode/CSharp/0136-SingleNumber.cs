﻿using LeetCode.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace LeetCode.CSharp
{
    internal class Solution0136 : IRunProgram
    {
        public void Run()
        {
            SingleNumber([2, 2, 1]).Print();
            SingleNumber([4, 1, 2, 1, 2]).Print();
            SingleNumber([1]).Print();
        }
        public int SingleNumber(int[] nums)
        {
            int xor = 0;

            foreach (var num in nums)
            {
                xor ^= num;
            }

            return xor;
        }
    }
}