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
    internal class Solution1716 : IRunProgram
    {
        public void Run()
        {
            TotalMoney(4).Print();
            TotalMoney(10).Print();
        }

        public int TotalMoney(int n)
        {
            const int DAY_COUNT = 7;
            int output = 0;

            for (int i = 0; i < n; i++)
            {
                int add = i / DAY_COUNT;
                output += add + (i % DAY_COUNT) + 1;
            }

            return output;
        }
    }
}