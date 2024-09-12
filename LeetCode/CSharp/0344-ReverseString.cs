using LeetCode.Shared;

namespace LeetCode.CSharp;

internal class Solution0344 : IRunProgram
{
    public void Run()
    {
        ReverseString("Hello".ToArray());
        ReverseString("Hannah".ToArray());
    }

    public void ReverseString(char[] s)
    {
        char l;
        for (int i = 0; i < s.Length / 2; i++)
        {
            l = s[i];
            s[i] = s[^(i + 1)];
            s[^(i + 1)] = l;
        }
    }
}
