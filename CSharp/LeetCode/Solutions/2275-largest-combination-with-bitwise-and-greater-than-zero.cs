using LeetCode.Solutions.Shared;

namespace LeetCode.Solutions;

internal class Solution2275 : IRunProgram
{
    public void Run()
    {

    }
    private const int MAX_BITS = 24;
    public int LargestCombination(int[] candidates)
    {
        Span<int> span = stackalloc int[MAX_BITS];
        int max = 0;
        foreach (int candidate in candidates)
        {
            int cand = candidate;
            for (int i = MAX_BITS; i >= 0; i--)
            {
                int pow = 1 << i;
                if (pow <= cand)
                {
                    span[i]++;
                    cand -= pow;
                    max = Math.Max(max, span[i]);
                    if (candidate == 0) break;
                }
            }
        }

        return max;
    }

}
