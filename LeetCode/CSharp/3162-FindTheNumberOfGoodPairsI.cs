using LeetCode.Shared;

namespace LeetCode.CSharp
{
    internal class Solution3162 : IRunProgram
    {
        public void Run()
        {
            NumberOfPairs([1, 3, 4], [1, 3, 4], 1).Print();
        }

        public int NumberOfPairs(int[] nums1, int[] nums2, int k)
        {
            Array.Sort(nums1);
            Array.Sort(nums2);

            int output = 0;
            int i = 0, j = 0;

            while (i < nums1.Length)
            {
                int quotient = nums1[i];
                int divisor = nums2[j] * k;
                if (quotient % divisor == 0)
                {
                    output++;
                }

                if (divisor > quotient || (j + 1) >= nums2.Length)
                {
                    i++;
                    j = 0;
                }
                else
                {
                    j = j < nums2.Length ? j + 1 : 0;
                }
            }

            return output;
        }
    }
}
