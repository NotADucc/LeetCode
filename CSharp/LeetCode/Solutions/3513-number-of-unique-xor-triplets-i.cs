using LeetCode.Solutions.Shared;

namespace LeetCode.Solutions;
internal class Solution3513 : IRunProgram
{
    public void Run()
    {

    }
    public int UniqueXorTriplets(int[] nums)
    {
        int n = nums.Length;
        if (n <= 2) return n;

        return 1 << Convert.ToString(n, 2).Length;
    }
}
