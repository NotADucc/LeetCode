using LeetCode.Shared;

namespace LeetCode.CSharp;

internal class Solution0001 : IRunProgram
{
    public void Run()
    {
        TwoSum([2, 7, 11, 15], 9).Print();
    }

    public int[] TwoSum(int[] nums, int target)
    {
        var deltas = new Dictionary<int, int>();

        for (int i = 0; i < nums.Length; i++)
        {
            if (deltas.ContainsKey(nums[i]))
            {
                return [deltas[nums[i]], i];
            }
            int delta = target - nums[i];
            deltas.TryAdd(delta, i);
        }

        return [];
    }
}
