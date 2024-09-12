using LeetCode.Shared;

namespace LeetCode.CSharp;

internal class Solution2486 : IRunProgram
{
    public void Run()
    {
        AppendCharacters("coaching", "coding").Print();
    }
    public int AppendCharacters(string s, string t)
    {
        int s_left = 0, t_left = 0;

        while (s_left < s.Length && t_left < t.Length)
        {
            if (s[s_left] == t[t_left])
            {
                t_left++;
            }
            s_left++;
        }

        return t.Length - t_left;
    }
}
