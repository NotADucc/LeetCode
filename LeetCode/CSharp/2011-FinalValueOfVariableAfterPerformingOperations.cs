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
    internal class Solution2011 : IRunProgram
    {
        public void Run()
        {
            FinalValueAfterOperations(["--X", "X++", "X++"]).Print();
        }
        public int FinalValueAfterOperations(string[] operations)
        {
            int x = 0;
            foreach (var item in operations)
            {
                if (item[0] == '-' || item[^1] == '-')
                {
                    x--;
                }
                else
                {
                    x++;
                }
            }
            return x;
        }
    }
}
