using LeetCode.Solutions.Shared;

namespace LeetCode.Solutions;

internal class Solution0424 : IRunProgram
{
    public void Run()
    {
        CharacterReplacement("ABAB" , 2).Print();
    }

    public int CharacterReplacement(string s, int k)
    {
        Span<int> freq = stackalloc int[26];
        int l = 0, r = 0, output = 0;

        while (r <= s.Length)
        {
            if (r - l - GetMax(freq) <= k)
            {
                if (r < s.Length) freq[s[r] - 'A']++;
                output = Math.Max(output, r - l);
                r++;
            }
            else
            {
                while (r - l - GetMax(freq) > k)
                {
                    freq[s[l++] - 'A']--;
                }
            }
        }

        return output;
    }

    private int GetMax(Span<int> span)
    {
        int max = 0;

        for (int i = 0; i < span.Length; i++) max = Math.Max(max, span[i]);

        return max;
    }
}
