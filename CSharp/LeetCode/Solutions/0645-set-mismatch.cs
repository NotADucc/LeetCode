using LeetCode.Solutions.Shared;

namespace LeetCode.Solutions;
internal class Solution0645 : IRunProgram
{
    public void Run()
    {

    }

    public int[] FindErrorNums(int[] nums)
    {
        int n = nums.Length;
        int sum = nums.Sum();
        int sum_no_duplicate = nums
            .Distinct()
            .Sum();
        int triangle = n * (n + 1) / 2;

        return [sum - sum_no_duplicate, triangle - sum_no_duplicate];
    }
}
