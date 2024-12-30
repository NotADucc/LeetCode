using LeetCode.Solutions.Shared;

namespace LeetCode.Solutions;

internal class Solution2466 : IRunProgram
{
    public void Run()
    {

    }

    public int CountGoodStrings(int low, int high, int zero, int one)
    {
        return DP(low, high, zero, one, 0);
    }

    private Dictionary<int, int> mem = new Dictionary<int, int>();
    private int DP(int low, int high, int zero, int one, int l)
    {
        if (l > high)
            return 0;

        if (!mem.ContainsKey(l))
        {
            int add = l >= low ? 1 : 0;
            mem[l] = (add + DP(low, high, zero, one, l + zero) + DP(low, high, zero, one, l + one)) % 1_000_000_007;
        }

        return mem[l];
    }
}
