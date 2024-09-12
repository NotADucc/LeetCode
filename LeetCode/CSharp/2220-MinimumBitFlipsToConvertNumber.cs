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
    internal class Solution2220 : IRunProgram
    {
        public void Run()
        {
            MinBitFlips(10, 7).Print();
        }

        public int MinBitFlips(int start, int goal)
        {
            return int.PopCount(start ^ goal);
        }
    }
}
