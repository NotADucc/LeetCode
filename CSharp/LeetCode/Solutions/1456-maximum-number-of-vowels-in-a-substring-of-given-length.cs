using LeetCode.Solutions.Shared;

namespace LeetCode.Solutions;

internal class Solution1456 : IRunProgram
{
    public void Run()
    {
        
    }

    public int MaxVowels(ReadOnlySpan<char> s, int k)
    {
        int l = 0, r = 0, output = 0, count = 0;

        for (; r < k && r < s.Length; r++)
        {
            if (IsVowel(s[r]))
            {
                count++;
                output = Math.Max(output, count);
            }
        }

        while (r < s.Length)
        {
            if (IsVowel(s[l++])) count--;
            if (IsVowel(s[r++])) count++;
            output = Math.Max(output, count);
        }

        return output;
    }
    private bool IsVowel(char ch) => ch == 'a' || ch == 'e' || ch == 'i' || ch == 'o' || ch == 'u';
}
