using LeetCode.Solutions.Shared;

namespace LeetCode.Solutions;

internal class Solution1829 : IRunProgram
{
    public void Run()
    {
        
    }

    public int[] GetMaximumXor(int[] nums, int maximumBit)
    {
        int max_num = (1 << maximumBit) - 1;
        int[] output = new int[nums.Length];

        for (int i = 1; i < nums.Length; i++)
        {
            nums[i] ^= nums[i - 1];
        }

        for (int i = 0; i < nums.Length; i++)
        {
            output[i] = max_num ^ nums[nums.Length - i - 1];
        }

        return output;
    }
}
