using LeetCode.Shared;

namespace LeetCode.CSharp
{
    internal class Solution1389 : IRunProgram
    {
        public void Run()
        {
            CreateTargetArray([0, 1, 2, 3, 4], [0, 1, 2, 2, 1]);
        }
        public int[] CreateTargetArray(int[] nums, int[] index)
        {
            if (nums.Length == 1)
            {
                return nums;
            }

            var output = new List<int>();

            for (int i = 0; i < nums.Length; i++)
            {
                int num = nums[i];
                int ind = index[i];

                output.Insert(ind, num);
            }

            return output.ToArray();
        }
    }
}
