using LeetCode.Shared;

namespace LeetCode.CSharp
{
    internal class Solution1920 : IRunProgram
    {
        public void Run()
        {
            BuildArray([0, 2, 1, 5, 3, 4]).Print();
        }
        public int[] BuildArray(int[] nums)
        {
            int[] a = new int[nums.Length];
            for (int i = 0; i < nums.Length; i++)
            {
                a[i] = nums[nums[i]];
            }
            return a;
        }
    }
}
