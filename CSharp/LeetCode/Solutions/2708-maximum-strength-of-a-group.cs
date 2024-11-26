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

        long res = 1;
        int biggest_neg = int.MinValue, factors = 0;
        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] != 0)
            {
                if (nums[i] < 0)
                {
                    biggest_neg = Math.Max(biggest_neg, nums[i]);
                }
                factors++;
                res *= nums[i];
            }
        }

        return res < 0 && factors > 1 ? res / biggest_neg : res > 0 && factors > 0 ? res : 0;
    }
}
