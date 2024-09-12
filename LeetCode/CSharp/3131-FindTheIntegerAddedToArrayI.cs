using LeetCode.Shared;

namespace LeetCode.CSharp
{
    internal class Solution3131 : IRunProgram
    {
        public void Run()
        {
            AddedInteger([2, 6, 4], [9, 7, 5]).Print();
        }

        public int AddedInteger(int[] nums1, int[] nums2)
        {
            int num2 = 0, num1 = 0;
            for (int i = 0; i < nums1.Length; i++)
            {
                num1 += nums1[i];
                num2 += nums2[i];
            }
            return (num2 - num1) / nums1.Length;
        }
    }
}
