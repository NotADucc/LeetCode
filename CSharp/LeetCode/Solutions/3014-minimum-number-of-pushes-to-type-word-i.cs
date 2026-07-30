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
        for (int i = 0; i < n; i++)
        {
            ans += (i / 8 + 1);
        }
        return ans;
    }
}
