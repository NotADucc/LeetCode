using LeetCode.Solutions.Shared;

namespace LeetCode.Solutions;

internal class Solution0492 : IRunProgram
{
    public void Run()
    {

    }

    public int[] ConstructRectangle(int area)
    {
        double sqrt = Math.Sqrt(area);
        int sqrt_int = Convert.ToInt32(sqrt);
        if (sqrt == sqrt_int) return [sqrt_int, sqrt_int];

        int w = sqrt_int, l = sqrt_int;
        while (w * l != area)
        {
            int calc_area = w * l;
            if (calc_area < area)
            {
                l++;
            }
            else if (calc_area > area && w > 1)
            {
                w--;
            }
            else
            {
                l++;
            }
        }

        return [l, w];
    }
}
