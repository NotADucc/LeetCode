﻿using LeetCode.Solutions.Shared;

namespace LeetCode.Solutions;

internal class Solution1106 : IRunProgram
{
    public void Run()
    {
        
    }

    public bool ParseBoolExpr(string expression)
    {
        Stack<char> stack = new Stack<char>();

        foreach (char ch in expression)
        {
            if (ch == ')')
            {
                bool contains_true = false, contains_false = false;
                while (stack.Peek() != '&' && stack.Peek() != '|' && stack.Peek() != '!')
                {
                    char pop_inner = stack.Pop();
                    if (pop_inner == 't') contains_true = true;
                    else contains_false = true;
                }
                char pop = stack.Pop();
                char add_ch = '\0';
                if (pop == '&') add_ch = contains_false ? 'f' : 't';
                else if (pop == '|') add_ch = contains_true ? 't' : 'f';
                else add_ch = contains_true ? 'f' : 't';
                stack.Push(add_ch);
            }
            else if (ch != ',' && ch != '(')
            {
                stack.Push(ch);
            }
        }

        return stack.Peek() == 't' ? true : false;
    }
}
