using LeetCode.Solutions.Shared;

namespace LeetCode.Solutions;

internal class Solution2563 : IRunProgram
{
    public void Run()
    {
        CountFairPairs([0, 1, 7, 4, 4, 5], 3, 6).Print();
        CountFairPairs([0, 0, 0, 0, 0, 0], 0, 0).Print();
    }
    public long CountFairPairs(int[] nums, int lower, int upper)
    {
        long output = 0;
        Array.Sort(nums);
        for (int i = 0; i < nums.Length; i++)
        {
            int lower_target = lower - nums[i];
            int upper_target = upper - nums[i];
            int lower_bound = Search(nums, lower_target, x => x < lower_target, x => x >= lower_target);
            int upper_bound = Search(nums, upper_target, x => x <= upper_target, x => x <= upper_target);
            if (lower_bound == -1) continue;
            lower_bound = Math.Max(lower_bound, i + 1);
            if (lower_bound > upper_bound) continue;
            output += upper_bound - lower_bound + 1;
        }

        return output;
    }

    private int Search(int[] arr, int target, Predicate<int> bs_comparison, Predicate<int> bs_result)
    {
        int l = 0, r = arr.Length - 1;

        while (l < r)
        {
            int mid = (l + r) >> 1;
            if (bs_comparison(arr[mid]))
            {
                l = mid + 1;
            }
            else
            {
                r = mid;
            }
        }

        return bs_result(arr[l]) ? l : l-- > 0 && bs_result(arr[l]) ? l : -1;
    }
}
