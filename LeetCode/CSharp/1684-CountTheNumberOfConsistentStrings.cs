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
    internal class Solution1678 : IRunProgram
    {
        public void Run()
        {
            CountConsistentStrings("ab", ["ad", "bd", "aaab", "baa", "badab"]).Print();
        }

        public int CountConsistentStrings(string allowed, string[] words)
        {
            int output = 0;
            for (int i = 0; i < words.Length; i++)
            {
                output++;
                for (int j = 0; j < words[i].Length; j++)
                {
                    if (!allowed.Contains(words[i][j]))
                    {
                        output--;
                        break;
                    }
                }
            }

            return output;
        }
    }
}
