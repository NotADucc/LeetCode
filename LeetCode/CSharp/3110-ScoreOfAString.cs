using LeetCode.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.CSharp
{
    internal class Solution3110 : IRunProgram
    {
        public void Run()
        {
            ScoreOfString("hello").Print();
            ScoreOfString("zaz").Print();
        }

        public int ScoreOfString(string s)
        {
            int score = 0;

            for (int i = 0; i < s.Length; i++)
            {
                if (i + 1 >= s.Length)
                {
                    break;
                }

                score += Math.Abs(s[i] - s[i + 1]);
            }

            return score;
        }
    }
}
