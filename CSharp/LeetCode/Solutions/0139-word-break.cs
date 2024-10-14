using LeetCode.Solutions.Shared;

namespace LeetCode.Solutions;

internal class Solution0139 : IRunProgram
{
    public void Run()
    {

    }

    public bool WordBreak(string s, IList<string> wordDict) 
    {
        int n = s.Length;
        var dp = new int[n + 1];

        for (int start = n - 1; start >= 0; start--) 
        {
            dp[start] = dp[start + 1] + 1;
            for (int end = start; end < n; end++) 
            {
                var curr = s.Substring(start, end + 1 - start);
                if (wordDict.Contains(curr)) 
                {
                    dp[start] = Math.Min(dp[start], dp[end + 1]);
                }
            }
        }

        return dp[0] == 0;     
    }
}
