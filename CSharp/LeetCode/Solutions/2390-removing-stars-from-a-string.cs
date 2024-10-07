using LeetCode.Solutions.Shared;

namespace LeetCode.Solutions;

internal class Solution2390 : IRunProgram
{
    public void Run()
    {
        RemoveStars("leet**cod*e").Print();
        RemoveStars("erase*****").Print();
    }
    public string RemoveStars(string s)
    {
        Span<char> output = stackalloc char[s.Length];
        int len = 0;

        for (int i = 0; i < s.Length; i++)
        {
            char ch = s[i];
            if (ch == '*')
            {
                len = Math.Max(0, len - 1);
            }
            else 
            {
                output[len++] = ch;
            }
        }

        return output.Slice(0, len).ToString();
    }
}
