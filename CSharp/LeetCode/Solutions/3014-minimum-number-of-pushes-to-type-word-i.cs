using LeetCode.Solutions.Shared;

namespace LeetCode.Solutions;
internal class Solution3014 : IRunProgram
{
    public void Run()
    {

    }
    public int MinimumPushes(string word)
    {
        int ans = 0, n = word.Length;
        int v = n / 8, r = n % 8;
        for (int i = 1; i <= v; i++)
            ans += i * 8;

        return ans + r * ++v;
    }
}
