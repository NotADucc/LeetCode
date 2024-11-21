using LeetCode.Solutions.Shared;

namespace LeetCode.Solutions;

internal class Solution2516 : IRunProgram
{
    public void Run()
    {
        TakeCharacters("aabbccca", 2).Print();
    }
    public int TakeCharacters(string s, int k)
    {
        if (k == 0) return 0;
        Span<int> freq = stackalloc int[] { -k, -k, -k };

        for (int i = 0; i < s.Length; i++)
        {
            int index = s[i] - 'a';
            freq[index]++;
        }

        for (int i = 0; i < freq.Length; i++)
        {
            if (freq[i] < 0) return -1;
        }
        int l = 0, r = 0, res = int.MaxValue;

        while (r <= s.Length)
        {
            int index = s[r++] - 'a';
            freq[index]--;

            while (freq[index] < 0)
            {
                int ldex = s[l++] - 'a';
                freq[ldex]++;
            }
            res = Math.Min(res, s.Length - (r - l));
            if (r >= s.Length) break;
        }

        return res;
    }
}
