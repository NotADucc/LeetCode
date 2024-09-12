using LeetCode.Shared;

namespace LeetCode.CSharp;

internal class Solution2894 : IRunProgram
{
    public void Run()
    {
        DifferenceOfSums(10, 3).Print();
        DifferenceOfSums(5, 6).Print();
    }

    public int DifferenceOfSums(int n, int m)
    {
        int output = 0;
        for (int i = 1; i <= n; i++)
        {
            if (i % m == 0)
            {
                output -= i;
            }
            else 
            {
                output += i;
            }
        }
        return output;
    }
}
