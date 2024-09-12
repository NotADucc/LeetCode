using LeetCode.CSharp.Shared;
using LeetCode.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace LeetCode.CSharp
{
    internal class Solution1025: IRunProgram
    {
        public void Run()
        {
            
        }

        public bool DivisorGame(int n)
        {
            return (n & 1) == 0;
        }
    }
}
