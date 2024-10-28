using LeetCode.Solutions.Shared;

namespace LeetCode.Solutions;

internal class Solution2501 : IRunProgram
{
    public void Run()
    {
        LongestSquareStreak([3, 9, 81, 6561]).Print();
    }
    public int LongestSquareStreak(int[] nums)
    {
        var set = new HashSet<int>(nums);
        int output = 0;

        for (int i = 0; i < nums.Length; i++)
        {
            int current = Help(nums[i], set);
            output = Math.Max(output, current);
        }

        return output <= 1 ? -1 : output;
    }

    private int Help(int num, HashSet<int> nums)
    {
        if (num >= 46_340 || !nums.Contains(num * num)) return 1;
        return 1 + Help(num * num, nums);
    }
}
