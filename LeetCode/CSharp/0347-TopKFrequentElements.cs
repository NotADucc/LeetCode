﻿using LeetCode.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.CSharp
{
    internal class Solution0347 : IRunProgram
    {
        public void Run()
        {
            TopKFrequent([1, 1, 1, 2, 2, 3], 2);
            TopKFrequent([1], 1);
        }

        public int[] TopKFrequent(int[] nums, int k)
        {
            var dct = new Dictionary<int, int>();

            foreach (int num in nums)
            {
                dct.TryAdd(num, 0);
                dct[num]++;
            }

            return dct.OrderByDescending(x => x.Value).Select(x => x.Key).Take(k).ToArray();
        }
    }
}