using LeetCode.Shared;

namespace LeetCode.CSharp;

internal class Solution1637 : IRunProgram
{
    public void Run()
    {
        MaxWidthOfVerticalArea([[8, 7], [9, 9], [7, 4], [9, 7]]).Print();
    }

    public int MaxWidthOfVerticalArea(int[][] points)
    {
        Array.Sort(points, new Comparison<int[]>(
            (x, y) => { return x[0] < y[0] ? -1 : (x[0] > y[0] ? 1 : 0); }
        ));

        int output = 0;
        for (int i = 0, j = 1; i < points.Length - 1; i++, j++)
        {
            output = Math.Max(output, points[j][0] - points[i][0]);
        }

        return output;
    }
}
