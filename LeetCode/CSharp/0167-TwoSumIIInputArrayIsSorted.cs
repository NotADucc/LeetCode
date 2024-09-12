using LeetCode.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace LeetCode.CSharp
{
    internal class Solution0167 : IRunProgram
    {
        public void Run()
        {
            TwoSum([2, 7, 11, 15], 9).Print();
            TwoSum([2, 3, 4], 6).Print();
        }

        public int[] TwoSum(int[] numbers, int target)
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                int delta = target - numbers[i];
                int search = Search(numbers, delta);
                if (search > -1)
                {
                    return [i + 1, search + 1];
                }
            }

            return [];
        }

        private int Search(int[] arr, int target)
        {
            int left = 0, right = arr.Length - 1;
            while (left <= right)
            {
                int mid = (left + right) >> 1;
                if (arr[mid] < target)
                {
                    left = mid + 1;
                }
                else if (arr[mid] > target)
                {
                    right = mid - 1;
                }
                else if (mid + 1 < arr.Length && arr[mid] == arr[mid + 1])
                {
                    left = mid + 1;
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
