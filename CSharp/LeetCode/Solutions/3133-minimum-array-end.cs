using LeetCode.Solutions.Shared;

namespace LeetCode.Solutions;

internal class Solution3133 : IRunProgram
{
    public void Run()
    {
        MinEnd(3, 4).Print();
        MinEnd(2, 7).Print();
        MinEnd(100_000_000, 100_000_000).Print();
    }

    public long MinEnd(int n, int x)
    {
        long result = x;
        for (var i = 0; i < n - 1; i++)
        {
            result++;
            result |= x;
        }

        return result;
    }
}
