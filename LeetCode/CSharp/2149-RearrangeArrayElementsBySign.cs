using LeetCode.Shared;

namespace LeetCode.CSharp
{
    internal class Solution2149 : IRunProgram
    {
        public void Run()
        {
            RearrangeArray([3, 1, -2, -5, 2, -4]).Print();
        }

        public int[] RearrangeArray(int[] nums)
        {
            var output = new int[nums.Length];

            int pos = 0, neg = 1;

            foreach (int num in nums)
            {
                if (num < 0)
                {
                    output[neg] = num;
                    neg += 2;
                }
                else
                {
                    output[pos] = num;
                    pos += 2;
                }
            }

            return output;
        }
    }
}
