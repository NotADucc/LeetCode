using LeetCode.Solutions.Shared;

namespace LeetCode.Solutions;

internal class Solution0198 : IRunProgram
{
    public void Run()
    {

    }

    public int Rob(int[] nums)
    {
        int rob1 = 0, rob2 = 0;
        for (int i = 0; i < nums.Length; i++)
        {
            int temp = Math.Max(rob1 + nums[i], rob2);
            rob1 = rob2;
            rob2 = temp;
        }
        return rob2;
    }
}
