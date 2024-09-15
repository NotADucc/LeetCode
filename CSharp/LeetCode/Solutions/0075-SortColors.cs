using LeetCode.Shared;

namespace LeetCode.CSharp;

public class Solution0075 : IRunProgram
{
    public void Run()
    {
        SortColors([2, 0, 2, 1, 1, 0]);
        SortColors([2, 0, 2]);
        SortColors([2, 0, 1]);
    }

    public void SortColors(int[] nums)
    {
        bool is_sorted = false;

        while (!is_sorted)
        {
            is_sorted = true;
            for (int i = 0; i < nums.Length - 1; i++)
            {
                if (nums[i] <= nums[i + 1])
                {
                    continue;
                }
                is_sorted = false;
                nums[i] ^= nums[i + 1];
                nums[i + 1] ^= nums[i];
                nums[i] ^= nums[i + 1];
            }
        }
    }
}
