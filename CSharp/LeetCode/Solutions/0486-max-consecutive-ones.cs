using LeetCode.Solutions.Shared;

namespace LeetCode.Solutions;

internal class Solution0485 : IRunProgram
{
    public void Run()
    {
        FindMaxConsecutiveOnes([1, 1, 0, 1, 1, 1]).Print();
        FindMaxConsecutiveOnes([1, 0, 1, 1, 0, 1]).Print();
        FindMaxConsecutiveOnes([0, 1, 1, 0, 1]).Print();
        FindMaxConsecutiveOnes([1, 1, 1, 1, 1]).Print();
    }
    public int FindMaxConsecutiveOnes(int[] nums)
    {
        int output = 0, current = 0; const int MAX = 1;
        for (int i = 0; i < nums.Length; i++)
        {
            current = nums[i] == 1 ? current + 1 : 0;
            output = Math.Max(output, current);
        }
        return output;
    }
}
