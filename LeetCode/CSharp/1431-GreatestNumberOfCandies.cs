﻿using LeetCode.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.CSharp
{
    internal class Solution1431 : IRunProgram
    {
        public void Run()
        {
            KidsWithCandies([2, 3, 5, 1, 3], 3).Print();
        }
        public IList<bool> KidsWithCandies(int[] candies, int extraCandies)
        {
            List<bool> output = new List<bool>();
            int max = candies.Max();

            for (int i = 0; i < candies.Length; i++)
            {
                output.Add(candies[i] + extraCandies >= max);
            }

            return output;
        }
    }
}