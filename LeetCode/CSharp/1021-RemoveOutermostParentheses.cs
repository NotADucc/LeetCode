using LeetCode.CSharp.Shared;
using LeetCode.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace LeetCode.CSharp
{
    internal class Solution1021: IRunProgram
    {
        public void Run()
        {
            RemoveOuterParentheses("(()())(())").Print();
        }

        public string RemoveOuterParentheses(string s)
        {
            Span<char> output = stackalloc char[s.Length];
            int size = 0;

            int current_open = 0;
            foreach (var ch in s)
            {
                if (ch == '(')
                {
                    if (current_open > 0)
                    {
                        output[size] = '(';
                        size++;
                    }

                    current_open++;
                }
                else
                {
                    if (current_open > 1)
                    {
                        output[size] = ')';
                        size++;
                    }

                    current_open--;
                }
            }

            return output.Slice(0, size).ToString();
        }
    }
}
