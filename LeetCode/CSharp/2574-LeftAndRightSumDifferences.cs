using LeetCode.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.CSharp
{
    internal class Solution2574 : IRunProgram
    {
        public void Run()
        {
            LeftRightDifference([10, 4, 8, 3]).Print();
        }

        public int[] LeftRightDifference(int[] nums)
        {
            var output = new int[nums.Length];

            for (int i = 0, j = 1; i < nums.Length; j++)
            {
                if (i + j >= nums.Length)
                {
                    i++;
                    j = 0;
                    continue;
                }

                output[i] += nums[i + j];
            }

            for (int i = nums.Length - 1, j = 1; i >= 0; j++)
            {
                if (i - j < 0)
                {
                    output[i] = Math.Abs(output[i]);
                    i--;
                    j = 0;
                    continue;
                }

                output[i] -= nums[i - j];
            }

            return output;
        }
    }
}
