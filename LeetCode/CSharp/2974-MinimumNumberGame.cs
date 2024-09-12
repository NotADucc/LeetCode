using LeetCode.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.CSharp
{
    internal class Solution2974 : IRunProgram
    {
        public void Run()
        {
            NumberGame([5, 4, 2, 3]).Print();
        }

        public int[] NumberGame(int[] nums)
        {
            Array.Sort(nums);

            for (int i = 0; i < nums.Length; i += 2)
            {
                nums[i] ^= nums[i + 1];
                nums[i + 1] ^= nums[i];
                nums[i] ^= nums[i + 1];
            }

            return nums;
        }
    }
}
