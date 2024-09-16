using LeetCode.Solutions.Shared;

namespace LeetCode.Solutions;

internal class Solution0326 : IRunProgram
{
    public void Run()
    {
        IsPowerOfThree(1).Print();
        IsPowerOfThree(3).Print();
        IsPowerOfThree(9).Print();
        IsPowerOfThree(59049).Print();
    }

    public bool IsPowerOfThree(int n)
    {
        return Math.Pow(3, Math.Ceiling(Math.Log(n, 3))) == n && n != 0;
    }
}
