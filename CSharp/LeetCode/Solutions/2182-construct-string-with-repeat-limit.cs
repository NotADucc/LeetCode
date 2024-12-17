using LeetCode.Solutions.Shared;
using System.Text;

namespace LeetCode.Solutions;

internal class Solution2182 : IRunProgram
{
    public void Run()
    {

    }

    public string RepeatLimitedString(string s, int repeatLimit)
    {
        static char IntToChar(int num) => (char)(num + 'a');
        var sb = new StringBuilder(s.Length);
        Span<int> span = stackalloc int[26];

        foreach (char ch in s) 
            span[ch - 'a']++;

        for (int i = 25; i >= 0; i--)
        {
            int len = Math.Min(span[i], repeatLimit);
            sb.Append(new string(IntToChar(i), len));
            span[i] -= len;

            if (span[i] <= 0) 
                continue;
            
            for (int j = i - 1; j >= 0; j--)
            {
                if (span[j] > 0 && sb[^1] != IntToChar(j))
                {
                    sb.Append(IntToChar(j));
                    span[j]--;
                    i++;
                    break;
                }
            }
        }

        return sb.ToString();
    }
}
