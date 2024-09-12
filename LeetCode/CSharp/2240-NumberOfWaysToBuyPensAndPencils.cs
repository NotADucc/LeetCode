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
    internal class Solution2240 : IRunProgram
    {
        public void Run()
        {
            WaysToBuyPensPencils(20, 10, 5).Print();
        }

        public long WaysToBuyPensPencils(int total, int cost1, int cost2)
        {
            int total_pens = total / cost1;
            long output = total / cost2 + 1;

            for (int i = 1; i <= total_pens; i++)
            {
                output += (total - (i * cost1)) / cost2 + 1;
            }

            return output;
        }
    }
}
