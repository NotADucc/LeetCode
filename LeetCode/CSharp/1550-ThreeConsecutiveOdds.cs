﻿using LeetCode.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.CSharp
{
    internal class Solution1550 : IRunProgram
    {
        public void Run()
        {
            ThreeConsecutiveOdds([2, 6, 4, 1]).Print();
            ThreeConsecutiveOdds([1, 2, 34, 3, 4, 5, 7, 23, 12]).Print();
        }
        public bool ThreeConsecutiveOdds(int[] arr)
        {
            for (int i = 0; i < arr.Length - 2; i++)
            {
                if (IsEven(arr[i]) || IsEven(arr[i + 1]) || IsEven(arr[i + 2]))
                {
                    continue;
                }
                return true;
            }

            return false;
        }
        private bool IsEven(int input) => (input & 1) == 0;
    }
}