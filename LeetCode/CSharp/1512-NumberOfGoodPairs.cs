using LeetCode.Shared;

namespace LeetCode.CSharp
{
    internal class Solution1512 : IRunProgram
    {
        public void Run()
        {
            NumIdenticalPairs([1, 2, 3, 1, 1, 3]).Print();
        }
        public int NumIdenticalPairs(int[] nums)
        {
            int cnt = 0;
            for (int i = 0; i < nums.Count(); i++)
            {
                for (int j = i + 1; j < nums.Count(); j++)
                {
                    if (nums[i] == nums[j])
                    {
                        cnt++;
                    }
                }
            }
            return cnt;
        }
    }
}
