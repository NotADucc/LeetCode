﻿using LeetCode.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.CSharp
{
    internal class Solution0338 : IRunProgram
    {
        public void Run()
        {
            CountBits(2).Print();
            CountBits(20).Print();
        }

        public int[] CountBits(int n)
        {
            int[] res = new int[n + 1];
            for (int i = 1; i <= n; i++)
            {
                res[i] = res[i / 2] + i % 2;
            }
            return res;
        }
    }
}