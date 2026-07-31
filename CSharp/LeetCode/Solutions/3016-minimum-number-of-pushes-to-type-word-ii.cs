using LeetCode.Solutions.Shared;

namespace LeetCode.Solutions;
internal class Solution3016 : IRunProgram
{
    public void Run()
    {

    }

    public int MinimumPushes(string word)
    {
        Span<int> freq = stackalloc int[26];
        foreach (char ch in word)
            freq[ch - 'a']++;

        MemoryExtensions.Sort(freq);

        int ans = 0, n = freq.Length;
        for (int i = 0; i < n; i++)
        {
            int cnt = freq[n - 1 - i];
            ans += (i / 8 + 1) * cnt;
        }

        return ans;
    }
}
