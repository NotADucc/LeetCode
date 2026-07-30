using LeetCode.Solutions.Shared;

namespace LeetCode.Solutions;
internal class Solution3751 : IRunProgram
{
    public void Run()
    {

    }
    public int TotalWaviness(int num1, int num2)
    {
        int ans = 0;
        num1 = Math.Max(num1, 100);
        for (int i = num1; i <= num2; i++)
        {
            string s = i.ToString();
            for (int j = 1; j < s.Length - 1; j++)
            {
                char c1 = s[j - 1];
                char c2 = s[j];
                char c3 = s[j + 1];
                if ((c1 > c2 && c2 < c3) || (c1 < c2 && c2 > c3)) 
                    ans++;
            }
        }
        return ans;
    }
}
