using LeetCode.Solutions.Shared;
using System.Globalization;

namespace LeetCode.Solutions;

internal class Solution2935 : IRunProgram
{
    public void Run()
    {
        MaximumStrongPairXor([1, 2, 3, 4, 5]).Print();
        MaximumStrongPairXor([1, 1, 2, 3, 8]).Print();
    }

    public int MaximumStrongPairXor(int[] nums)
    {
        //TODO TLE
        if (nums.Length == 1) return 0;

        Array.Sort(nums);
        int output = 0;
        for (int i = 0; i < nums.Length; i++)
        {
            int w1 = nums[i];
            int w2_i = Search(nums, w1);
            while (w2_i > i)
            {
                output = Math.Max(output, w1 ^ nums[w2_i]);
                w2_i--;
            }
        }

        return output;
    }

    public int Search(int[] arr, int target)
    {
        int l = 0, r = arr.Length - 1;
        target <<= 1;
        while (l <= r)
        {
            int mid = (l + r) >> 1;
            if (arr[mid] < target)
            {
                l = mid + 1;
            }
            else if (arr[mid] > target)
            {
                r = mid - 1;
            }
            else
            {
                return mid;
            }
        }

        return Math.Max(l - 1, 0);
    }
}
