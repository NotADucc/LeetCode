using LeetCode.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.CSharp
{
    internal class Solution2390 : IRunProgram
    {
        public void Run()
        {
            RemoveStars("leet**cod*e").Print();
        }
        public string RemoveStars(string s)
        {
            Stack<char> stack = new Stack<char>();
            foreach (var ch in s)
            {
                if (ch == '*')
                {
                    if (stack.Count > 0) stack.Pop();
                }
                else
                {
                    stack.Push(ch);
                }
            }
            Span<char> output = stackalloc char[stack.Count];
            int i = stack.Count - 1;
            while (stack.Count > 0)
            {
                output[i--] = stack.Pop();
            }
            return output.ToString();
        }
    }
}
