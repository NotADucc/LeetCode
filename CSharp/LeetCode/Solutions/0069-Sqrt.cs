using LeetCode.Shared;

namespace LeetCode.CSharp;

public class Solution0069 : IRunProgram
{
    public void Run()
    {
        MySqrt(4).Print();
        MySqrt(8).Print();
    }

    public int MySqrt(int x)
    {
        double left = 0, right = x;
        while (left < right)
        {
            double mid = (left + right) / 2;
            if (Math.Floor(mid * mid) < x)
            {
                left = mid;
            }
            else if (Math.Floor(mid * mid) > x)
            {
                right = mid;
            }
            else
            {
                return (int)Math.Floor(mid);
            }
        }
        return (int)Math.Floor(left);
    }
}
