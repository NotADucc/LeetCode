using LeetCode.Solutions.Shared;
using System.Text;

namespace LeetCode.Solutions;

internal class Solution2109 : IRunProgram
{
    public void Run()
    {
        
    }

    public string AddSpaces(string s, int[] spaces)
    {
        ReadOnlySpan<char> span = s.AsSpan();
        StringBuilder sb = new StringBuilder(s.Length + spaces.Length);
        int latest_idx = 0;

        for (int i = 0; i < spaces.Length; i++)
        {
            sb.Append(span.Slice(latest_idx, spaces[i] - latest_idx));
            sb.Append(' ');
            latest_idx = spaces[i];
        }
        
        if (latest_idx < s.Length)
            sb.Append(span.Slice(latest_idx));

        return sb.ToString();
    }
}
