using LeetCode.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.CSharp
{
    internal class Solution0009 : IRunProgram
    {
        public void Run()
        {
            IsPalindrome(121).Print();
            IsPalindrome(1221).Print();
            IsPalindrome(12321).Print();
            IsPalindrome(13321).Print();
        }
        public bool IsPalindrome(int x)
        {
            if (x < 0)
            {
                return false;
            }
            string sX = x.ToString();
            for (int i = 0; i < sX.Length / 2; i++)
            {
                if (!sX[i].Equals(sX[^(i + 1)]))
                {
                    return false;
                }
            }
            return true;
        }
    }
}
