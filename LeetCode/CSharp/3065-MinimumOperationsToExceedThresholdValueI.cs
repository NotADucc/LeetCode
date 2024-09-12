using LeetCode.Shared;

namespace LeetCode.CSharp
{
    internal class Solution3065 : IRunProgram
    {
        public void Run()
        {
            MinOperations([2, 11, 10, 1, 3], 10).Print();
        }

        public int MinOperations(int[] nums, int k)
        {
            Array.Sort(nums);
            int left = 0, right = nums.Length - 1;
            while (left <= right)
            {
                int mid = (left + right) / 2;
                if (nums[mid] < k)
                {
                    left = mid + 1;
                }
                else if (nums[mid] > k)
                {
                    right = mid - 1;
                }
                else
                {
                    right = mid - 1;
                }
            }
            return left;
        }
    }
}
