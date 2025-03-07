﻿using LeetCode.Solutions.Shared;

namespace LeetCode.Solutions;

internal class Solution0231 : IRunProgram
{
    public void Run()
    {
        IsPowerOfTwo(4).Print();
    }

    public bool IsPowerOfTwo(int n)
    {
        return int.PopCount(n) == 1 && n != -2147483648;
    }
}
