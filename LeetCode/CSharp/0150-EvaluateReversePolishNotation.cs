using LeetCode.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace LeetCode.CSharp
{
    internal class Solution0150 : IRunProgram
    {
        public void Run()
        {
            EvalRPN(["2", "1", "+", "3", "*"]).Print();
        }
        public int EvalRPN(string[] tokens)
        {
            var stack = new Stack<int>();

            foreach (var token in tokens)
            {
                if (stack.Count > 1)
                {
                    if (token == "+")
                    {
                        stack.Push(stack.Pop() + stack.Pop());
                    }
                    else if (token == "-")
                    {
                        stack.Push((stack.Pop() - stack.Pop()) * -1);
                    }
                    else if (token == "*")
                    {
                        stack.Push(stack.Pop() * stack.Pop());
                    }
                    else if (token == "/")
                    {
                        int num1 = stack.Pop();
                        int num2 = stack.Pop();
                        stack.Push(num2 / num1);
                    }
                    else
                    {
                        stack.Push(int.Parse(token));
                    }
                }
                else
                {
                    stack.Push(int.Parse(token));
                }
            }

            return stack.Pop();
        }
    }
}
