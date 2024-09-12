using LeetCode.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.CSharp
{
    public class Solution0070 : IRunProgram
    {
        public void Run()
        {
            ClimbStairs(2).Print();
            ClimbStairs(3).Print();
            ClimbStairs(4).Print();
            ClimbStairs(8).Print();
        }

        public int ClimbStairs(int n)
        {
            int a = 0;
            int b = 1;

            for (int i = 0; i < n; i++)
            {
                int temp = a;
                a = b;
                b += temp;
            }

            return b;
        }
    }
}
