using LeetCode.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.CSharp
{
    internal class Solution1614 : IRunProgram
    {
        public void Run()
        {
            MaxDepth("(1+(2*3)+((8)/4))+1").Print();
        }

        public int MaxDepth(string s)
        {
            int max = 0;
            int current = 0;

            foreach (var ch in s)
            {
                if (ch == '(')
                {
                    current++;
                    max = Math.Max(max, current);
                }
                else if (ch == ')')
                {
                    current--;
                }
            }

            return max;
        }
    }
}
