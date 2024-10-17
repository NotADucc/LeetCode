using LeetCode.Solutions.Shared;

namespace LeetCode.Solutions;

internal class Solution0344 : IRunProgram
{
    public void Run()
    {
        ReverseString("Hello".ToArray());
        ReverseString("Hannah".ToArray());
    }

    public void ReverseString(char[] s)
    {
        int l = 0, r = s.Length - 1;
        while (l < r)
        {
            s[l] ^= s[r];
            s[r] ^= s[l];
            s[l] ^= s[r];
            l++;
            r--;
        }
    }
}
