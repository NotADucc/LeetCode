using LeetCode.Solutions.Shared;

namespace LeetCode.Solutions;

internal class Solution1232 : IRunProgram
{
    public void Run()
    {

    }

    public bool CheckStraightLine(int[][] coordinates)
    {
        if (coordinates.Length < 3) return true;
        int x0 = coordinates[0][0], x1 = coordinates[1][0];
        int y0 = coordinates[0][1], y1 = coordinates[1][1];
        for (int i = 2; i < coordinates.Length; i++)
        {
            int x2 = coordinates[i][0], y2 = coordinates[i][1];
            if ((y2 - y1) * (x1 - x0) != (y1 - y0) * (x2 - x1)) return false;
        }
        return true;
    }
}
