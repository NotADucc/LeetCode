using LeetCode.Shared;

namespace LeetCode.CSharp;

internal class Solution0137 : IRunProgram
{
    public void Run()
    {
        // TODO: currently invalid
        // using extra space

        SingleNumber([2, 2, 2, 1]).Print();
        SingleNumber([4, 1, 2, 2, 1, 1, 2]).Print();
        SingleNumber([0, 1, 0, 1, 0, 1, 99]).Print();
    }
    public int SingleNumber(int[] nums)
    {
        return nums
            .GroupBy(x => x)
            .ToDictionary(x => x.Key, x => x.Count())
            .First(x => x.Value == 1)
            .Key;
    }
}
