using LeetCode.Shared;

namespace LeetCode.CSharp;

internal class Solution0459 : IRunProgram
{
    public void Run()
    {
        RepeatedSubstringPattern("aa").Print();
        RepeatedSubstringPattern("ab").Print();
    }
    public bool RepeatedSubstringPattern(string s)
    {
        if (s.Length == 1) return false;

        var span = s.AsSpan();
        var len = span.Length;

        int i, j;
        for (i = 0; i < len; i++)
        {
            if (i > (len - 1) >> 1) return false;
            for (j = i + 1; j < len; j += i + 1)
            {
                if (j + i + 1 > len || !span.Slice(j, i + 1).StartsWith(span.Slice(0, i + 1)))
                {
                    break;
                }
            }
            if (j >= len) break;
        }

        return i != len;
    }
}
