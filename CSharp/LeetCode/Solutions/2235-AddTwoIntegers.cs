using LeetCode.Shared;

namespace LeetCode.CSharp;

internal class Solution2235 : IRunProgram
{
    public void Run()
    {
        Sum(10, 7).Print();
    }

    public int Sum(int num1, int num2) => num1 + num2;
}
