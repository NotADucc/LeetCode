using LeetCode.Solutions.Shared;

namespace LeetCode.Solutions;
internal class Solution3622 : IRunProgram
{
    public void Run()
    {

    }
    public bool CheckDivisibility(int n)
    {
        int prod = 1, sum = 0, nn = n;

        while (nn > 0)
        {
            int rest = nn % 10;
            prod *= rest;
            sum += rest;
            nn /= 10;
        }

        return n % (prod + sum) == 0;
    }
}
