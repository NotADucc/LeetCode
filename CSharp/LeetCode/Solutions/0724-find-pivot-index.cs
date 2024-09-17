using LeetCode.Solutions.Shared;

namespace LeetCode.Solutions;

internal class Solution0724 : IRunProgram
{
    public void Run()
    {

    }

    public int PivotIndex(int[] nums)
    {
        int[] nums2 = nums.ToArray();
        for (int i = 1; i < nums.Length; i++)
        {
            nums[i] += nums[i - 1];
            nums2[^(1 + i)] += nums2[^i];
        }

        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] == nums2[i])
            {
                return i;
            }
        }

        return -1;
    }
}
