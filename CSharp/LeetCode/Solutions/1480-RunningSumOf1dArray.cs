using LeetCode.Shared;

namespace LeetCode.CSharp;

internal class Solution1480 : IRunProgram
{
    public void Run()
    {
        RunningSum([1, 2, 3, 4]).Print();
    }
    public int[] RunningSum(int[] nums)
    {
        for (int i = 0; i < nums.Count() - 1; i++)
        {
            nums[i + 1] += nums[i];
        }

        return nums;
    }
}
