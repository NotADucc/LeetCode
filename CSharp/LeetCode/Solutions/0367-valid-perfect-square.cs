using LeetCode.Solutions.Shared;

namespace LeetCode.Solutions;

internal class Solution0367 : IRunProgram
{
    public void Run()
    {
        int.MaxValue.Print();
        IsPerfectSquare(808201).Print();
        IsPerfectSquare(2000105819).Print();
    }
    public bool IsPerfectSquare(int num)
    {
        int l = 0, r = num;
        while (l <= r)
        {
            int mid = (int)(((long)l + r) >> 1);
            long mult = mid * mid;
            if (mid > 46_340)
            {
                r = mid - 1;
            } 
            else if (mult < num)
            {
                l = mid + 1;
            }
            else if (mult > num)
            {
                r = mid - 1;
            }
            else
            {
                return true;
            }
        }
        return false;
    }
}
