using LeetCode.Solutions.Shared;

namespace LeetCode.Solutions;
internal class Solution0041 : IRunProgram
{
    public void Run()
    {

    }

    public int FirstMissingPositive(int[] nums)
    {
        int n = nums.Length;
        var missing = new bool[n + 1];
        foreach (var num in nums)
        {
            if (num <= 0 || num > n) continue;
            missing[num - 1] = true;
        }

        for (int i = 0; i < missing.Length; i++)
        {
            if (!missing[i]) return i + 1;
        }

        return -1;
    }
}
