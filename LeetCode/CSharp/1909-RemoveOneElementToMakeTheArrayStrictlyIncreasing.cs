using LeetCode.Shared;

namespace LeetCode.CSharp
{
    internal class Solution1909 : IRunProgram
    {
        public void Run()
        {
            CanBeIncreasing([1, 2, 10, 5, 7]).Print();
        }

        public bool CanBeIncreasing(int[] nums)
        {
            if (nums.Length == 2)
            {
                return true;
            }

            bool removed_element = false;
            for (int i = 0; i < nums.Length - 1; i++)
            {
                if (nums[i] < nums[i + 1])
                {
                    continue;
                }

                if (removed_element)
                {
                    return false;
                }

                removed_element = true;

                if (i == 0)
                {
                    continue;
                }

                if (nums[i + 1] <= nums[i - 1])
                {
                    nums[i + 1] = i + 2 == nums.Length ? nums[i] + 1 : nums[i];
                }
                else
                {
                    nums[i] = nums[i - 1];
                    i--;
                }
            }

            return nums[^2] < nums[^1];
        }
    }
}
