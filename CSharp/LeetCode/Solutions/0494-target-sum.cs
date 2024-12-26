using LeetCode.Solutions.Shared;
using System;

namespace LeetCode.Solutions;

internal class Solution0494 : IRunProgram
{
    public void Run()
    {
        FindTargetSumWays([1, 1, 1, 1, 1], 3).Print();
        FindTargetSumWays([1], 1).Print();
    }
    public int FindTargetSumWays(int[] nums, int target)
    {
        return Rec(nums, 0, target, 0);
    }

    private Dictionary<(int, int), int> mem = new Dictionary<(int, int), int>();
    private int Rec(int[] nums, int curr, int target, int idx)
    {
        if (idx >= nums.Length)
        {
            return curr == target ? 1 : 0;
        }
        else
        {
            if (!mem.ContainsKey((curr, idx)))
                mem[(curr, idx)] = Rec(nums, curr - nums[idx], target, idx + 1) + Rec(nums, curr + nums[idx], target, idx + 1);
            return mem[(curr, idx)];
        }
    }
}
