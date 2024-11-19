using LeetCode.Solutions.Shared;

namespace LeetCode.Solutions;

internal class Solution2461 : IRunProgram
{
    public void Run()
    {
        MaximumSubarraySum([1, 5, 4, 2, 9, 9, 9], 3).Print();
    }
    public long MaximumSubarraySum(int[] nums, int k)
    {
        long res = 0, curr = 0;
        //key is val
        //val is index
        var freq = new Dictionary<int, int>();
        int l = 0, r = 0;

        while (r < nums.Length)
        {
            if (freq.TryAdd(nums[r], r))
            {
                curr += nums[r++];
                if (freq.Count >= k)
                {
                    res = Math.Max(res, curr);
                    int val = nums[l++];
                    freq.Remove(val);
                    curr -= val;
                }
            }
            else
            {
                int i = freq[nums[r]];
                while (l <= i)
                {
                    int val = nums[l++];
                    freq.Remove(val);
                    curr -= val;
                }
            }
        }

        return res;
    }
}
