using LeetCode.Solutions.Shared;

namespace LeetCode.Solutions;

internal class Solution2185 : IRunProgram
{
    public void Run()
    {

    }
    public int PrefixCount(string[] words, string pref)
    {
        int res = 0, n = pref.Length;

        for (int i = 0; i < words.Length; i++)
        {
            var s = words[i].AsSpan();
            if (s.Length < n)
                continue;
            int j = 0;
            for (; j < n; j++)
            {
                if (s[j] != pref[j])
                {
                    break;
                }
            }
            if (j >= n) res++;
        }

        return res;
    }
}
