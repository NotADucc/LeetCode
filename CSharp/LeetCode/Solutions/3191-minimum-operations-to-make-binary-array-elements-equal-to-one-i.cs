using LeetCode.Solutions.Shared;

namespace LeetCode.Solutions;

internal class Solution3191 : IRunProgram
{
    public void Run()
    {

    }
    public int MinOperations(int[] nums)
    {
        int res = 0, n = nums.Length;

        for (int i = 0; i < n - 2; i++)
        {
            if (nums[i] == 0)
            {
                nums[i] = 1;
                nums[i + 1] = (nums[i + 1] + 1) % 2;
                nums[i + 2] = (nums[i + 2] + 1) % 2;
                res++;
            }
        }

        return nums[^1] + nums[^2] == 2 ? res : -1;
    }
}
