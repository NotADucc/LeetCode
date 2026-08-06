using LeetCode.Solutions.Shared;

namespace LeetCode.Solutions;
internal class Solution3345 : IRunProgram
{
    public void Run()
    {

    }
    public int SmallestNumber(int n, int t)
    {
        for (int i = n;; i++)
        {
            int d = 1, dd = i;
            while (dd > 0)
            {
                d *= dd % 10;
                dd /= 10;
            }

            if (d % t == 0)
                return i;
        }
    }
}
