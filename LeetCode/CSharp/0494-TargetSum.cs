using LeetCode.Shared;
using System;

namespace LeetCode.CSharp;

internal class Solution0494 : IRunProgram
{
    public void Run()
    {
        FindTargetSumWays([1, 1, 1, 1, 1], 3).Print();
        FindTargetSumWays([1], 1).Print();
    }
    public int FindTargetSumWays(int[] nums, int target)
    {
        return Backtrack(nums, 0, target, 0);
    }

    private int Backtrack(int[] nums, int current, int target, int index) 
    {
        if (nums.Length == index)
        {
            return current == target ? 1 : 0;
        }
        else
        {
            return Backtrack(nums, current - nums[index], target, index + 1) +
            Backtrack(nums, current + nums[index], target, index + 1);
        }
    }
}
