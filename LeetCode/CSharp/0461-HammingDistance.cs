﻿using LeetCode.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.CSharp
{
    internal class Solution0461 : IRunProgram
    {
        public void Run()
        {
            HammingDistance(1, 4).Print();
        }
        public int HammingDistance(int x, int y)
        {
            int xor = x ^ y;
            int output = 0;

            while (xor > 0)
            {
                output += xor & 1;
                xor >>= 1;
            }

            return output;
        }
    }
}