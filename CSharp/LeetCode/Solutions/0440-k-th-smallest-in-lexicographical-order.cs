using LeetCode.Solutions.Shared;

namespace LeetCode.Solutions;

internal class Solution0440 : IRunProgram
{
    public void Run()
    {
        FindKthNumber(130, 44).Print();
    }

    public int FindKthNumber(int n, int k)
    {
        int curr = 1;
        k--;

        while (k > 0)
        {
            int step = CountSteps(n, curr, curr + 1);
            if (step <= k)
            {
                curr++;
                k -= step;
            }
            else
            {
                curr *= 10;
                k--;
            }
        }

        return curr;
    }

    private int CountSteps(int n, long prefix1, long prefix2)
    {
        long steps = 0;
        while (prefix1 <= n)
        {
            steps += Math.Min(n + 1, prefix2) - prefix1;
            prefix1 *= 10;
            prefix2 *= 10;
        }
        return (int)steps;
    }
}
