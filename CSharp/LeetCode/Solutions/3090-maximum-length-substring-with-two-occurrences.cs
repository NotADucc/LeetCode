using LeetCode.Solutions.Shared;
using System;

namespace LeetCode.Solutions;
internal class Solution3090 : IRunProgram
{
    public void Run()
    {
        MaximumLengthSubstring("bcbbbcba").Print();
        MaximumLengthSubstring("aaaa").Print();
        MaximumLengthSubstring("bcbazertyuiopqsdfbbcba").Print();
    }
    
    public int MaximumLengthSubstring(string s)
    {
        int ans = 0, n = s.Length;
        Span<int> arr = stackalloc int[26];

        for (int r = 0, l = 0; r < n; r++)
        {
            var index = s[r] - 'a';
            arr[index]++;

            while (arr[index] > 2)
            {
                arr[s[l] - 'a']--;
                l++;
            }

            ans = Math.Max(ans, r - l + 1);
        }

        return ans;
    }
}
