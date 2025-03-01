using LeetCode.Solutions.Shared;

namespace LeetCode.Solutions
{
    internal class Solution2460 : IRunProgram
    {
        public void Run()
        {

        }

        public int[] ApplyOperations(int[] nums)
        {
            int[] res = new int[nums.Length];
            int res_idx = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] == 0) continue;
                res[res_idx++] = i + 1 < nums.Length && nums[i] == nums[i + 1]
                    ? nums[i++] << 1 : nums[i];
            }

            return res;
        }
    }
}
