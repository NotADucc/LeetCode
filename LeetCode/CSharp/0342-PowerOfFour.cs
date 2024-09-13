using LeetCode.Shared;

namespace LeetCode.CSharp;

internal class Solution0342 : IRunProgram
{
    public void Run()
    {

    }

    public bool IsPowerOfFour(int n)
    {
        return n > 0 && int.PopCount(n) == 1 && (int.TrailingZeroCount(n) & 1) == 0;
    }
}
