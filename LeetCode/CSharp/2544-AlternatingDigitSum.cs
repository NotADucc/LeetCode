﻿using LeetCode.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.CSharp
{
    internal class Solution2544 : IRunProgram
    {
        public void Run()
        {
            AlternateDigitSum(521).Print();
        }

        public int AlternateDigitSum(int n)
        {
            var s = n.ToString(); n = 0;

            for (int i = 0; i < s.Length; i++)
            {
                if ((i & 1) == 0)
                {
                    n += s[i] - '0';
                }
                else
                {
                    n -= s[i] - '0';
                }
            }

            return n;
        }
    }
}