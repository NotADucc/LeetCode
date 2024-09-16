using LeetCode.Solutions.Shared;

namespace LeetCode.Solutions;

internal class Solution2529 : IRunProgram
{
    public void Run()
    {
        MaximumCount([-2, -1, -1, 1, 2, 3]).Print();
    }
    public int MaximumCount(int[] nums)
    {
        if (nums.Length == 1)
        {
            return nums[0] == 0 ? 0 : 1;
        }
        int neg_index = HelperNegative(nums);
        int pos_index = HelperPositive(nums);

        var neg_total = neg_index;
        var pos_total = nums.Length - pos_index;


        return Math.Max(neg_total, pos_total);
    }

    int HelperNegative(int[] arr)
    {
        int left = 0, right = arr.Length - 1;

        while (left <= right)
        {
            int m = (left + right) / 2;

            if (int.IsNegative(arr[m]))
            {
                left = m + 1;
            }
            else
            {
                right = m - 1;
            }
        }

        return left;
    }

    int HelperPositive(int[] arr)
    {
        int left = 0, right = arr.Length - 1;

        while (left <= right)
        {
            int m = (left + right) / 2;

            if (int.IsPositive(arr[m]) && arr[m] != 0)
            {
                right = m - 1;
            }
            else
            {
                left = m + 1;
            }
        }

        return left;
    }
}
