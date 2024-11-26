using LeetCode.Solutions.Shared;

namespace LeetCode.Solutions
{
    internal class Solution1984 : IRunProgram
    {
        public void Run()
        {

        }

        public int MinimumDifference(int[] nums, int k)
        {
            int res = int.MaxValue; k--;

            Array.Sort(nums);

            for (int i = 0; i < nums.Length - k; i++)
            {
                res = Math.Min(res, nums[i + k] - nums[i]);
            }

            return res;
        }
    }
}
