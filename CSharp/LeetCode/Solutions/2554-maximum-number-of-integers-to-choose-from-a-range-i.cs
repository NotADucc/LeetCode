using LeetCode.Solutions.Shared;

namespace LeetCode.Solutions;

internal class Solution2554 : IRunProgram
{
    public void Run()
    {
        
    }

    public int MaxCount(int[] banned, int n, int maxSum)
    {
        HashSet<int> ban = new HashSet<int>(banned);
        int res = 0, curr = 0;
        for (int i = 1; i <= n; i++)
        {
            if (!ban.Contains(i) && curr + i <= maxSum)
            {
                curr += i;
                res++;
            }
        }

        return res;
    }
}
