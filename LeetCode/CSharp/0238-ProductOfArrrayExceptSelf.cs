using LeetCode.Shared;

namespace LeetCode.CSharp
{
    internal class Solution0238 : IRunProgram
    {
        public void Run()
        {
            // TODO: Current is invalid
            // This uses division operation
        }

        public int[] ProductExceptSelf(int[] nums)
        {
            int prod_all = 1, int_prod_no_zero = 1, zero_count = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                prod_all *= nums[i];
                if (nums[i] == 0)
                {
                    zero_count++;
                    int_prod_no_zero *= 1;
                }
                else
                {
                    int_prod_no_zero *= nums[i];
                }
            }

            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] != 0)
                {
                    nums[i] = prod_all / nums[i];
                }
                else
                {
                    nums[i] = zero_count > 1 ? 0 : int_prod_no_zero;
                }
            }

            return nums;
        }
    }
}
