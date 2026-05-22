using LeetCode.Solutions.Shared;

namespace LeetCode.Solutions;
internal class Solution0033 : IRunProgram
{
    public void Run()
    {
        Search([1], 2).Print();
        Search([1, 3], 3).Print();
        Search([3, 5, 1], 3).Print();
    }
    public int Search(int[] nums, int target)
    {
        int l = 0, r = nums.Length - 1;
        while (l <= r)
        {
            int m = (l + r) >> 1;
            if (nums[m] == target)
                return m;

            bool decision = target < nums[m]
                ? nums[r] < nums[l] && target <= nums[r] && nums[m] > nums[r]
                : !(nums[r] < nums[l] && target >= nums[l] && nums[l] > nums[m]);

            if (decision)
            {
                l = m + 1;
            }
            else
            {
                r = m - 1;
            }
        }

        return -1;
    }

}
