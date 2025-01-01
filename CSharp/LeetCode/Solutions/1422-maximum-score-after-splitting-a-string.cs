using LeetCode.Solutions.Shared;

namespace LeetCode.Solutions;

internal class Solution1422 : IRunProgram
{
    public void Run()
    {

    }

    public int MaxScore(string s)
    {
        int zero_cnt = 0, one_cnt = 0, res = 0;

        foreach (char ch in s)
        {
            one_cnt += ch - '0';
        }

        for (int i = 0; i < s.Length - 1; i++)
        {
            char ch = s[i];
            if (ch == '0')
            {
                zero_cnt++;
            }
            else
            {
                one_cnt--;
            }
            res = Math.Max(res, zero_cnt + one_cnt);
        }

        return res;
    }
}
