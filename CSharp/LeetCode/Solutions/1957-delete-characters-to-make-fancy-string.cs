using LeetCode.Solutions.Shared;
using System.Text;

namespace LeetCode.Solutions;

internal class Solution1957 : IRunProgram
{
    public void Run()
    {

    }

    public string MakeFancyString(string s)
    {
        StringBuilder sb = new StringBuilder();
        for (int i = 0; i < s.Length; i++)
        {
            if (sb.Length < 2 || (sb[sb.Length - 2] != sb[sb.Length - 1] || sb[sb.Length - 1] != s[i]))
            {
                sb.Append(s[i]);
            }
        }
        return sb.ToString();
    }
}
