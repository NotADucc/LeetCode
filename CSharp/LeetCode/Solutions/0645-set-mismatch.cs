using LeetCode.Solutions.Shared;

namespace LeetCode.Solutions;
internal class Solution0645 : IRunProgram
{
    public void Run()
    {

    }

    public int[] FindErrorNums(int[] nums)
    {
        HashSet<int> set = new HashSet<int>();
        int sum = 0, sum_no_duplicate = 0;
        foreach (var num in nums)
        {
            sum += num;
            if (set.Add(num))
                sum_no_duplicate += num;
        }

        int n = nums.Length;
        int triangle = n * (n + 1) / 2;

        return [sum - sum_no_duplicate, triangle - sum_no_duplicate];
    }
}
