using LeetCode.Solutions.Shared;

namespace LeetCode.Solutions;

internal class Solution3011 : IRunProgram
{
    public void Run()
    {
        
    }

    public bool CanSortArray(int[] nums) 
    {
        bool is_sorted = false;

        while (!is_sorted)
        {
            is_sorted = true;
            for (int i = 0; i < nums.Length - 1; i++)
            {
                if (nums[i] <= nums[i + 1])
                    continue;
                if (int.PopCount(nums[i]) != int.PopCount(nums[i + 1]))
                    return false;
                is_sorted = false;
                nums[i] ^= nums[i + 1];
                nums[i + 1] ^= nums[i];
                nums[i] ^= nums[i + 1];
            }
        }

        return true;
    }
}
