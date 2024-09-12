using LeetCode.Shared;
using System.Text;

namespace LeetCode.CSharp;

internal class Solution0151 : IRunProgram
{
    public void Run()
    {
        ReverseWords("the sky is blue").Print();
        ReverseWords("  hello world ").Print();
    }
    public string ReverseWords(string s)
    {
        ReadOnlySpan<char> span = s.AsSpan().Trim();
        StringBuilder sb = new StringBuilder(span.Length);
        int index = 0;
        for (int i = span.Length - 1; i >= 0; i--)
        {
            if (span[i] == ' ')
            {
                if (sb[^1] == ' ')
                {
                    continue;
                }
                sb.Append(" ");
                index = sb.Length;
            }
            else
            {
                sb.Insert(index, span[i]);
            }
        }

        return sb.ToString();
    }
}
