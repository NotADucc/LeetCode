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
    internal class Solution0713: IRunProgram
    {
        public void Run()
        {
            NumSubarrayProductLessThanK([10, 5, 2, 6], 100).Print();
        }
        public int NumSubarrayProductLessThanK(int[] nums, int k)
        {
            int output = 0;

            for (int w1 = 0; w1 < nums.Length; w1++)
            {
                int temp = 1, w2 = 0;
                while (w1 + w2 < nums.Length)
                {
                    temp = temp * nums[w1 + w2];
                    if (temp < k)
                    {
                        output++;
                        w2++;
                    }
                    else
                    {
                        break;
                    }
                }
            }

            return output;
        }
    }
}
