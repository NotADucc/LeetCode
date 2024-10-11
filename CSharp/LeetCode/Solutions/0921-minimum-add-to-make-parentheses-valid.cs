using LeetCode.Solutions.Shared;

namespace LeetCode.Solutions;

internal class Solution0921 : IRunProgram
{
    public void Run()
    {

    }

    public int MinAddToMakeValid(string s) 
    {
        int count = 0, output = 0;
        foreach (char ch in s)
        {
            if (ch == '(')
            {
                count++;
            }
            else
            {
                if (count <= 0)
                {
                    output++;
                }
                else
                {
                    count--;
                }
            }
        }
        return count + output;    
    }
}
