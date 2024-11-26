using LeetCode.Solutions.Shared;

namespace LeetCode.Solutions;

internal class Solution2708 : IRunProgram
{
    public void Run()
    {
        
    }

    public long MaxStrength(int[] nums)
    {
        if (nums.Length == 1) return nums[0];

        long res = 1; bool b = false;
        Array.Sort(nums);
        for (int i = 0; i < nums.Length; i++)
        {
            if ((i + 1 < nums.Length && nums[i] < 0 && nums[i + 1] < 0) || res < 0 && nums[i] < 0 || nums[i] > 0)
            {
                res *= nums[i];
                b = true;
            }
        }

        return b ? res : 0;
    }
}
