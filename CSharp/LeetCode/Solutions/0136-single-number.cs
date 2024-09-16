using LeetCode.Solutions.Shared;

namespace LeetCode.Solutions;

internal class Solution0136 : IRunProgram
{
    public void Run()
    {
        SingleNumber([2, 2, 1]).Print();
        SingleNumber([4, 1, 2, 1, 2]).Print();
        SingleNumber([1]).Print();
    }
    public int SingleNumber(int[] nums)
    {
        int xor = 0;

        foreach (var num in nums)
        {
            xor ^= num;
        }

        return xor;
    }
}
