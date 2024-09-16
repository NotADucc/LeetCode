using LeetCode.Solutions.Shared;

namespace LeetCode.Solutions;

internal class Solution2177 : IRunProgram
{
    public void Run()
    {
        SumOfThree(33).Print();
    }

    public long[] SumOfThree(long num)
    {
        long middle = num / 3;
        if (middle - 1 + middle + middle + 1 == num)
        {
            return [middle - 1, middle, middle + 1];
        }
        else
        {
            return [];
        }
    }
}
