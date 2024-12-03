using LeetCode.Solutions.Shared;

namespace LeetCode.Solutions;

internal class Solution2109 : IRunProgram
{
    public void Run()
    {
        
    }

    public string AddSpaces(string s, int[] spaces)
    {
        StringBuilder sb = new StringBuilder(s.Length + spaces.Length);
        int space_idx = 0;
        for (int i = 0; i < s.Length; i++)
        {
            if (space_idx < spaces.Length && spaces[space_idx] == i)
            {
                sb.Append(' ');
                space_idx++;
            }
            sb.Append(s[i]);
        }

        return sb.ToString();
    }
}
