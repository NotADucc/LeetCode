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
    internal class Solution0704: IRunProgram
    {
        public void Run()
        {
            Search([-1, 0, 3, 5, 9, 12], 9).Print();
        }
        public int Search(int[] nums, int target)
        {
            int left = 0, right = nums.Length - 1;
            while (left <= right)
            {
                int mid = (left + right) >> 1;
                if (nums[mid] < target)
                {
                    left = mid + 1;
                }
                else if (nums[mid] > target)
                {
                    right = mid - 1;
                }
                else
                {
                    return mid;
                }
            }
            return -1;
        }
    }
}
