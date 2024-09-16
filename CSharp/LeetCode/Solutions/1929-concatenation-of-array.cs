using LeetCode.Solutions.Shared;

namespace LeetCode.Solutions;

internal class Solution1929 : IRunProgram
{
    public void Run()
    {
        GetConcatenation([1, 2, 1]).Print();
    }
    public int[] GetConcatenation(int[] nums)
    {
        var a = new int[nums.Length * 2];
        Array.Copy(nums, 0, a, 0, nums.Length);
        Array.Copy(nums, 0, a, nums.Length, nums.Length);
        return a;
    }
}
