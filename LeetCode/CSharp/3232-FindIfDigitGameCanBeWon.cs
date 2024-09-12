using LeetCode.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.CSharp
{
    internal class Solution3232 : IRunProgram
    {
        public void Run()
        {
            CanAliceWin([1, 2, 3, 4, 10]).Print();
        }

        public bool CanAliceWin(int[] nums)
        {
            int dig = 0;
            int ddig = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] >= 10)
                {
                    ddig += nums[i];
                }
                else
                {
                    dig += nums[i];
                }
            }

            return dig != ddig;
        }
    }
}
