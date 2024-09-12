using LeetCode.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.CSharp
{
    internal class Solution0168 : IRunProgram
    {
        public void Run()
        {
            ConvertToTitle(1).Print();
            ConvertToTitle(28).Print();
            ConvertToTitle(70149123).Print();
        }


        private const int _ASCII_BASE = 64;

        public string ConvertToTitle(int columnNumber)
        {
            string output = string.Empty;

            while (columnNumber > 0)
            {
                int rest = columnNumber % 26;
                rest = rest == 0 ? 26 : rest;
                output = (char)(rest + _ASCII_BASE) + output;

                columnNumber -= rest;
                columnNumber /= 26;
            }

            return output;
        }
    }
}
