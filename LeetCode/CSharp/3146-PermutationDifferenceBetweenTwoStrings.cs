using LeetCode.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.CSharp
{
    internal class Solution3146 : IRunProgram
    {
        public void Run()
        {
            FindPermutationDifference("abc", "bac").Print();
        }

        public int FindPermutationDifference(string s, string t)
        {
            int delta = 0;

            for (int i = 0; i < s.Length; i++)
            {
                delta += Math.Abs(t.IndexOf(s[i]) - i);
            }

            return delta;
        }
    }
}
