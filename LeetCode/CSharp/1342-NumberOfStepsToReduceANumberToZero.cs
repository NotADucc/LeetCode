using LeetCode.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.CSharp
{
    internal class Solution1342 : IRunProgram
    {
        public void Run()
        {
            NumberOfSteps(2).Print();
            NumberOfSteps(14).Print();
        }
        public int NumberOfSteps(int num)
        {
            int c = 0;
            while (num != 0)
            {
                if ((num & 1) == 0)
                {
                    num = num >> 1;
                }
                else
                {
                    num--;
                }
                c++;
            }
            return c;
        }
    }
}
