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
    internal class Solution1833 : IRunProgram
    {
        public void Run()
        {
            // TODO: cheese
            MaxIceCream([1, 3, 2, 4, 1], 7).Print();
        }

        public int MaxIceCream(int[] costs, int coins)
        {
            Array.Sort(costs);
            int total = 0;
            foreach (var a in costs)
            {
                if (a > coins)
                {
                    return total;
                }
                coins -= a;
                total++;
            }
            return total;
        }
    }
}
