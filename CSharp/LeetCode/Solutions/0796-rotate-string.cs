using LeetCode.Solutions.Shared;

namespace LeetCode.Solutions;

internal class Solution0796 : IRunProgram
{
    public void Run()
    {
        
    }

    public bool RotateString(string s, string goal)
    {
        if (s.Length != goal.Length) return false;

        for (int i = 0; i < goal.Length; i++)
        {
            int start_index = goal.Substring(i).IndexOf(s[0]);
            if (start_index == -1) return false;
            string temp = goal.Substring(i + start_index) + goal.Substring(0, i);
            if (s.Equals(temp)) return true;
        }

        return false;
    }
}
