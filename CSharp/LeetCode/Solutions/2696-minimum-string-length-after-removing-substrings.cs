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
        
        while (changed)
        {
            changed = false;
            string temp = s.Replace("AB", "");
            if (temp.Length != s.Length)
            {
                changed = true;
                s = temp;
            }
            temp = s.Replace("CD", "");
            if (temp.Length != s.Length)
            {
                changed = true;
                s = temp;
            }
        }

        return s.Length; 
    }
}
