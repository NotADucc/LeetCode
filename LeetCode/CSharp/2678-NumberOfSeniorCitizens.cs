using LeetCode.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.CSharp
{
    internal class Solution2678 : IRunProgram
    {
        public void Run()
        {
            CountSeniors(["7868190130M7522", "5303914400F9211", "9273338290F4010"]).Print();
        }

        public int CountSeniors(string[] details)
        {
            int output = 0;

            foreach (string s in details)
            {
                if (s[11] > '6' || (s[11] == '6' && s[12] != '0'))
                {
                    output++;
                }
            }

            return output;
        }
    }
}
