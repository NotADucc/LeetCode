using LeetCode.Solutions.Shared;

namespace LeetCode.Solutions;
internal class Solution3512 : IRunProgram
{
    public void Run()
    {

    }

    public int MinOperations(int[] nums, int k)
    {
        return nums.Sum() % k;
    }
}
