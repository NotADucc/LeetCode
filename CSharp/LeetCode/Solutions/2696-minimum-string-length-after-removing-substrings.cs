using LeetCode.Solutions.Shared;

namespace LeetCode.Solutions;

internal class Solution2696 : IRunProgram
{
    public void Run()
    {

    }

    public int MinLength(string s) 
    {
        bool changed = true;
        var sb = new StringBuilder(s);
        while (changed)
        {
            changed = false;
            for (int i = 0; i < sb.Length - 1; i++)
            {
                if ((sb[i] == 'A' && sb[i + 1] == 'B') || (sb[i] == 'C' && sb[i + 1] == 'D'))
                {
                    changed = true;
                    sb.Remove(i, 2);
                }
            }
        }

        return sb.Length; 
    }
}
