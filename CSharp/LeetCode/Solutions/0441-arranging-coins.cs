using LeetCode.Solutions.Shared;
using System.Security.Cryptography;

namespace LeetCode.Solutions;

internal class Solution0441 : IRunProgram
{
    public void Run()
    {
        ArrangeCoins(1804289383).Print();
    }

    public int ArrangeCoins(int n)
    {
        long l = 0, r = n - 1;
        while (l <= r)
        {
            long mid = l + r >> 1;
            long bin = mid * (mid + 1) >> 1;
            if (bin < n)
            {
                l = mid + 1;
            }
            else if (bin > n)
            {
                r = mid - 1;
            }
            else
            {
                return (int)mid;
            }
        }
        return l * (l + 1) >> 1 > n ? (int)l - 1 : (int)l;
    }
}
