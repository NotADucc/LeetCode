using LeetCode.Shared;

namespace LeetCode.CSharp;

internal class Solution0342 : IRunProgram
{
    public void Run()
    {
        Math.Log(4, 4).Print();
        Math.Pow(1, 4).Print();
    }

    public bool IsPowerOfFour(int n)
    {
        return Math.Pow(Math.Ceiling(Math.Log(n, 4)), 4) == n && n != 0;
    }
}
