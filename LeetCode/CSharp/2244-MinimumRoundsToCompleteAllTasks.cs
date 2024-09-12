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
    internal class Solution2244 : IRunProgram
    {
        public void Run()
        {
            MinimumRounds([2, 2, 3, 3, 2, 4, 4, 4, 4, 4]).Print();
        }

        public int MinimumRounds(int[] arr)
        {
            List<int> lst = new List<int>(arr);
            var a = lst.GroupBy(x => x).Select(x => (x.Key, x.Count()));
            int amount = 0;
            foreach (var b in a)
            {
                if (b.Item2 == 1)
                {
                    return -1;
                }
                int target = b.Item2;
                if (target % 3 != 0 && target > 2 && target != 5)
                {
                    amount += 2;
                    target -= 4;
                }
                amount += (target / 3) + ((target % 3) / 2);
            }
            return amount;
        }
    }
}
