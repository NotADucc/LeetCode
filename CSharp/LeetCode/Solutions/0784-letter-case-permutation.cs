using LeetCode.Shared;
using System.Text;

namespace LeetCode.CSharp;

internal class Solution0784: IRunProgram
{
    public void Run()
    {
        LetterCasePermutation("a1b2").Print();
        LetterCasePermutation("3z4").Print();
    }
    public IList<string> LetterCasePermutation(string s)
    {
        List<string> output = new List<string>();
        Helper(output, new StringBuilder(), s, 0);
        return output;
    }

    private void Helper(List<string> output, StringBuilder sb, string s, int index)
    {
        if (sb.Length == s.Length)
        {
            output.Add(sb.ToString());
        }
        else
        {
            char ch = s[index];
            sb.Append(ch);
            Helper(output, sb, s, index + 1);
            sb.Remove(sb.Length - 1, 1);
            if (char.IsAsciiLetter(ch))
            {
                ch = char.IsAsciiLetterLower(ch) ? (char)(ch - 32) : (char)(ch + 32);
                sb.Append(ch);
                Helper(output, sb, s, index + 1);
                sb.Remove(sb.Length - 1, 1);
            }
        }
    }
}
