using LeetCode.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace LeetCode.CSharp
{
    internal class Solution0476 : IRunProgram
    {
        public void Run()
        {
            FindComplement(5).Print();
            FindComplement(1).Print();
        }
        public int FindComplement(int num)
        {
            int multi = 1;
            int rest = 0;

            while (multi + rest < num)
            {
                rest += multi;
                multi <<= 1;
            }
            multi += rest;
            return multi ^ num;
        }
    }
}
