using LeetCode.Shared;

namespace LeetCode.CSharp;

internal class Solution3190 : IRunProgram
{
    public void Run()
    {
        MinimumOperations([1, 2, 3, 4]).Print();
    }

    public int MinimumOperations(int[] nums)
    {
        int count = 0;
        foreach (var num in nums)
        {
            if (num % 3 != 0)
            {
                count++;
            }
        }
        return count;
    }
}
