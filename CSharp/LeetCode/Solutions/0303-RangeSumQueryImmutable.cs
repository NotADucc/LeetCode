using LeetCode.Shared;

namespace LeetCode.CSharp;

internal class Solution0303 : IRunProgram
{
    public void Run()
    {
        
    }
}

public class NumArray
{
    int[] prefix;
    public NumArray(int[] nums)
    {
        for (int i = 1; i < nums.Length; i++)
        {
            nums[i] += nums[i - 1];
        }
        prefix = nums;
    }

    public int SumRange(int left, int right)
    {
        int sum = prefix[right];
        if (left > 0)
        {
            sum -= prefix[left - 1];
        }
        return sum;
    }
}
