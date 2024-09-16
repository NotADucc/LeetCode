using LeetCode.Solutions.Shared;

namespace LeetCode.Solutions;

internal class Solution2932 : IRunProgram
{
    public void Run()
    {
        MaximumStrongPairXor([1, 2, 3, 4, 5]).Print();
    }

    public int MaximumStrongPairXor(int[] nums)
    {
        int output = 0;

        int w1 = 0, w2 = 0;

        Array.Sort(nums);
        while (w1 < nums.Length)
        {
            if (Math.Abs(nums[w1] - nums[w2]) <= Math.Min(nums[w1], nums[w2]))
            {
                output = Math.Max(output, nums[w1] ^ nums[w2]);
            }
            if (w2 + 1 < nums.Length)
            {
                w2++;
            }
            else
            {
                w1++;
                w2 = w1;
            }
        }

        return output;
    }
}
