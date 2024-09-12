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
            return int.PopCount(n) == 1 && n != -2147483648;
        }
    }
}
