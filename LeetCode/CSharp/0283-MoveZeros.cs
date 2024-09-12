using LeetCode.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.CSharp
{
    internal class Solution0283 : IRunProgram
    {
        public void Run()
        {
            MoveZeroes([0, 1, 0, 3, 12]);
            MoveZeroes([0]);
        }

        public void MoveZeroes(int[] nums)
        {

            int index = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] != 0)
                {
                    bool was0 = nums[index] == 0;
                    nums[index] = nums[i];
                    nums[i] = was0 ? 0 : nums[i];
                    index++;
                }
            }
        }
    }
}
