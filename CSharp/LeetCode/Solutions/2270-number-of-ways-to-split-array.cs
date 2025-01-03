using LeetCode.Solutions.Shared;

namespace LeetCode.Solutions;

internal class Solution2270 : IRunProgram
{
    public void Run()
    {

    }

    public int WaysToSplitArray(int[] nums)
    {
        int res = 0;
        long[] nums_l = new long[nums.Length];
        nums_l[0] = nums[0];

        for (int i = 1; i < nums_l.Length; i++)
        {
            nums_l[i] = nums_l[i - 1] + nums[i];
        }

        for (int i = 0; i < nums_l.Length - 1; i++)
        {
            if (nums_l[i] >= nums_l[^1] - nums_l[i])
            {
                res++;
            }
        }

        return res;
    }
}
