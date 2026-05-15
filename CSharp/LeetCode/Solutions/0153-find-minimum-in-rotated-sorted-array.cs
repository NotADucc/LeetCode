using LeetCode.Solutions.Shared;

namespace LeetCode.Solutions;
internal class Solution0153 : IRunProgram
{
    public void Run()
    {
        FindMin([3, 4, 5, 1, 2]).Print();
        FindMin([4, 5, 6, 7, 0, 1, 2]).Print();
        FindMin([11, 13, 15, 17]).Print();
        FindMin([3, 1, 2]).Print();
    }

    public int FindMin(int[] nums)
    {
        if (nums[0] <= nums[^1])
            return nums[0];

        int l = 0, r = nums.Length - 1;
        while (l < r)
        {
            int middle = (l + r) >> 1;
            if (nums[middle] >= nums[r])
            {
                l = middle + 1;
            }
            else
            {
                r = middle;
            }
        }

        return nums[l];
    }
}
