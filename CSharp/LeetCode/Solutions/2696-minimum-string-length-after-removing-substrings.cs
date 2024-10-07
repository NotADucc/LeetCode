using LeetCode.Solutions.Shared;

namespace LeetCode.Solutions;

internal class Solution2696 : IRunProgram
{
    public void Run()
    {

    }

    public int MinLength(string s) 
    {
        var stack = new Stack<char>();

        for (int i = 0; i < s.Length; i++)
        {
            if (stack.Count == 0)
            {
                stack.Push(s[i]);
            }
            else
            {
                char ch = stack.Peek();
                if (ch == 'A' && s[i] == 'B' || ch == 'C' && s[i] == 'D') 
                {
                    stack.Pop();
                }
                else
                {
                    stack.Push(s[i]);
                }
            }
        }   

        return stack.Count;
    }
}
