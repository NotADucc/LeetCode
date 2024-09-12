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
    internal class Solution1721 : IRunProgram
    {
        public void Run()
        {
            LargestAltitude([-5, 1, 5, 0, -7]).Print();
        }

        public int LargestAltitude(int[] gain)
        {
            int max = 0, curr = 0;
            for (int i = 0; i < gain.Length; i++)
            {
                curr += gain[i];
                if (curr > max)
                {
                    max = curr;
                }
            }
            return max;
        }
    }
}
