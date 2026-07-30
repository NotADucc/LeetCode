using LeetCode.Solutions.Shared;

namespace LeetCode.Solutions;
internal class Solution0551 : IRunProgram
{
    public void Run()
    {

    }

    public bool CheckRecord(string s)
    {
        int a = 0, n = s.Length;

        for (int i = 0; i < n; i++)
        {
            char ch = s[i];
            if (ch == 'A') a++;
            else if (ch == 'P') continue;
            else if (i + 2 < n && s[i + 1] == 'L' && s[i + 2] == 'L') return false;
        }

        return a < 2;
    }
}
