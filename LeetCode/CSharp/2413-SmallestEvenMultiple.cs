﻿using LeetCode.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.CSharp
{
    internal class Solution2413 : IRunProgram
    {
        public void Run()
        {
            SmallestEvenMultiple(5).Print();
            SmallestEvenMultiple(6).Print();
        }

        public int SmallestEvenMultiple(int n)
        {
            return ((n & 1) + 1) * n;
        }

        public int SmallestEvenMultipleternary(int n)
        {
            return (n & 1) == 0 ? n : n * 2;
        }
    }
}