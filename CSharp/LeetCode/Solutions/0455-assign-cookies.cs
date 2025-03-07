﻿using LeetCode.Solutions.Shared;

namespace LeetCode.Solutions;

internal class Solution0455 : IRunProgram
{
    public void Run()
    {
        FindContentChildren([1, 2, 3], [1, 1]).Print();
    }
    public int FindContentChildren(int[] g, int[] s)
    {
        Array.Sort(g);
        Array.Sort(s);

        int child = 0;
        int cookie = 0;
        while (child < g.Length && cookie < s.Length)
        {
            if (g[child] > s[cookie])
            {
                cookie++;
                continue;
            }

            child++;
            cookie++;
        }

        return child;
    }
}
