using LeetCode.Solutions.Shared;

namespace LeetCode.Solutions;

internal class Solution1493 : IRunProgram
{
    public void Run()
    {
        
    }

    public int LongestSubarray(int[] nums)
    {
        Span<int> freqs = stackalloc int[2];
        int l = 0, r = 0, output = 0, k = 1;
        while (r <= nums.Length)
        {
            if (freqs[0] <= k)
            {
                if (r < nums.Length) freqs[nums[r]]++;
                r++;
                output = Math.Max(output, r - 2 - l);
            }
            else
            {
                while (freqs[0] > k)
                {
                    freqs[nums[l++]]--;
                }
            }
        }
        return output;
    }
}
