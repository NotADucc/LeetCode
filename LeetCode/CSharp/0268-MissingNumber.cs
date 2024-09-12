using LeetCode.Shared;

namespace LeetCode.CSharp
{
    internal class Solution0268 : IRunProgram
    {
        public void Run()
        {
            MissingNumber([3, 0, 1]).Print();
            MissingNumber([0, 1]).Print();
            MissingNumber([9, 6, 4, 2, 3, 5, 7, 0, 1]).Print();
        }

        public int MissingNumber(int[] nums)
        {
            int max_value = nums.Length, sum_numbers = 0;

            foreach (var num in nums)
            {
                sum_numbers += num;
            }

            int triangle_number = (max_value * (max_value + 1)) >> 1;
            int missing_number = triangle_number - sum_numbers;

            return missing_number;
        }
    }
}
