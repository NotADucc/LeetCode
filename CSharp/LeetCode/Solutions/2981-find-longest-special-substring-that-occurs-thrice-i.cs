using LeetCode.Solutions.Shared;

namespace LeetCode.Solutions;

internal class Solution2981 : IRunProgram
{
    public void Run()
    {

    }

    public int MaximumLength(string s)
    {
        bool IsSpecial(ReadOnlySpan<char> str)
        {
            for (int i = 0; i < str.Length; i++)
                if (str[0] != str[i]) return false;
            return true;
        }

        int res = -1;
        ReadOnlySpan<char> span = s.AsSpan();
        Span<int> freq = stackalloc int[26];
        for (int i = 1; i < s.Length; i++)
        {
            for (int j = 0; j < s.Length - i + 1; j++)
            {
                if (!IsSpecial(span.Slice(j, i)))
                    continue;
                int ch = span[j] - 'a';
                freq[ch]++;
                if (freq[ch] >= 3)
                {
                    res = i;
                    break;
                }
            }

            freq = stackalloc int[26];
        }

        return res;
    }
}
