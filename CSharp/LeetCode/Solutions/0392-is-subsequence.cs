﻿using LeetCode.Solutions.Shared;

namespace LeetCode.Solutions;

internal class Solution0392 : IRunProgram
{
    public void Run()
    {
        IsSubsequence("abc", "ahbgdc").Print();
        IsSubsequence("axc", "ahbgdc").Print();
    }

    public bool IsSubsequence(string s, string t)
    {
        if (t.Length == 0)
        {
            return s.Length == t.Length;
        }

        int i = 0;
        int j = 0;

        while (i < s.Length && j < t.Length)
        {
            if (s[i] != t[j])
            {
                j++;
                continue;
            }
            i++;
            j++;
        }

        return i == s.Length;
    }
}
