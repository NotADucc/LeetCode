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
    internal class Solution2180 : IRunProgram
    {
        public void Run()
        {
            CountEven(4).Print();
            CountEven(30).Print();
        }

        public int CountEven(int num)
        {
            int ans = 0;
            int temp_num = num;
            while (num > 0)
            {
                ans += num % 10;
                num /= 10;
            }

            return (temp_num - ((ans & 1) == 1 ? 1 : 0)) >> 1;
        }
    }
}
