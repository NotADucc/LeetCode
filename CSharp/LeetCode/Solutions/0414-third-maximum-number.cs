using LeetCode.Solutions.Shared;

namespace LeetCode.Solutions;

internal class Solution0414 : IRunProgram
{
    public void Run()
    {
        
    }

    public int ThirdMax(int[] nums)
    {
        nums = nums.Distinct().ToArray();
        Array.Sort(nums);
        if (nums.Length < 3) return nums[^1];

        return nums[^3];
    }
}
