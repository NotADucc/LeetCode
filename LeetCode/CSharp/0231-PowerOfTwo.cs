using LeetCode.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.CSharp
{
    internal class Solution0231 : IRunProgram
    {
        public void Run()
        {
            IsPowerOfTwo(4).Print();
        }

        public bool IsPowerOfTwo(int n)
        {
            if (n == 1)
            {
                return true;
            }
            int i = Convert.ToString(n, 2).Length - 1;
            return ((n >> i) << i) == n && n != 0 && n != -2147483648;
        }
    }
}
