using LeetCode.Solutions.Shared;
using System.Text;

namespace LeetCode.Solutions;

internal class Solution0214 : IRunProgram
{
    public void Run()
    {
        ShortestPalindrome("aacecaaa").Print();
    }

    public string ShortestPalindrome(string s)
    {
        int l = 0, r = s.Length;
        ReadOnlySpan<char> span = s;
        ReadOnlySpan<char> reversed = new string(s.Reverse().ToArray());
        while (r > 0)
        {
            ReadOnlySpan<char> slice1 = span.Slice(0, r);
            ReadOnlySpan<char> slice2 = reversed.Slice(l, reversed.Length - l);
            if (IsEqual(slice1, slice2))
            {
                break;
            }
            else
            {
                l++; r--;
            }
        }

        return reversed.Slice(0, l).ToString() + s;
    }

    private bool IsEqual(ReadOnlySpan<char> s1, ReadOnlySpan<char> s2)
    {
        for (int i = 0; i < s1.Length; i++)
        {
            if (s1[i] != s2[i]) return false;
        }
        return true;
    }
}
