using LeetCode.Solutions.Shared;

namespace LeetCode.Solutions;

internal class Solution2873 : IRunProgram
{
    public void Run()
    {

    }

    public long MaximumTripletValue(int[] nums)
    {
        long res = 0L;
        int n = nums.Length;

        for (int i = 0; i < n; i++)
        {
            for (int j = i + 1; j < n; j++)
            {
                for (int k = j + 1; k < n; k++)
                {
                    res = Math.Max(res, ((long)nums[i] - nums[j]) * nums[k]);
                }
            }
        }
        return res;
    }
}
