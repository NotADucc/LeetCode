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
    internal class Solution2160 : IRunProgram
    {
        public void Run()
        {
            MinimumSum(2932).Print();
        }

        public int MinimumSum(int num)
        {
            var temp = num.ToString().ToArray();
            Array.Sort(temp);

            int n1 = int.Parse($"{temp[0]}{temp[2]}");
            int n2 = int.Parse($"{temp[1]}{temp[3]}");

            return n1 + n2;
        }
    }
}
