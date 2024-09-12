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
    internal class Solution0985: IRunProgram
    {
        public void Run()
        {
            SumEvenAfterQueries([1, 2, 3, 4], [[1, 0], [-3, 1], [-4, 0], [2, 3]]).Print();
        }

        public int[] SumEvenAfterQueries(int[] nums, int[][] queries)
        {
            var answer = new List<int>(nums.Length);
            int even = 0;

            foreach (var num in nums)
            {
                if (IsEven(num))
                {
                    even += num;
                }
            }
            foreach (var query in queries)
            {
                int val = query[0];
                int i = query[1];

                if (IsEven(nums[i]))
                {
                    even -= nums[i];
                }

                nums[i] += val;

                if (IsEven(nums[i]))
                {
                    even += nums[i];
                }

                answer.Add(even);
            }

            return answer.ToArray();
        }

        bool IsEven(int g) => (g & 1) == 0;
    }
}
