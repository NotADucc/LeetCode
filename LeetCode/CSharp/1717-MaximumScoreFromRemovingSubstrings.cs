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
    internal class Solution1717 : IRunProgram
    {
        public void Run()
        {
            MaximumGain("cdbcbbaaabab", 4, 5).Print();
        }

        public int MaximumGain(string s, int x, int y)
        {
            //x is ab
            //y is ba

            (int high_score, string high_replace, int low_score, string low_replace) =
                x < y ? (y, "ba", x, "ab") : (x, "ab", y, "ba");
            string temp = s;
            int output_low = 0, output_high = 0;
            while (true)
            {
                string replaced = s.Replace(high_replace, "");
                while (replaced.Length != s.Length)
                {
                    output_high += (s.Length - replaced.Length >> 1) * high_score;
                    s = replaced;
                    replaced = s.Replace(high_replace, "");
                }

                replaced = s.Replace(low_replace, "");
                if (replaced.Length == s.Length)
                {
                    break;
                }
                output_high += (s.Length - replaced.Length >> 1) * low_score;
                s = replaced;
            }

            return output_high;
        }
    }
}
