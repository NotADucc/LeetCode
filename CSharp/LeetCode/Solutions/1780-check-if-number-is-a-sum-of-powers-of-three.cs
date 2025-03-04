using LeetCode.Solutions.Shared;

namespace LeetCode.Solutions;

internal class Solution1780 : IRunProgram
{
    public void Run()
    {

    }

    public bool CheckPowersOfThree(int n)
    {
        int pwr = 1_162_261_467;

        while (pwr > 0)
        {
            if (n >= pwr)
                n -= pwr;
            pwr /= 3;
        }

        return n == 0;
    }
}
