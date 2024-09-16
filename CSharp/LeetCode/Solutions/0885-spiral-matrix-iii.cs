using LeetCode.Solutions.Shared;

namespace LeetCode.Solutions;

internal class Solution0885: IRunProgram
{
    public void Run()
    {
        SpiralMatrixIII(1, 4, 0, 0).Print();
    }
    public int[][] SpiralMatrixIII(int rows, int cols, int rStart, int cStart)
    {
        var grid = new int[rows][];
        for (int i = 0; i < rows; i++) grid[i] = new int[cols];

        int grid_size = rows * cols;


        (int y, int x)[] dirs = [(0, 1), (1, 0), (0, -1), (-1, 0)];


        (int y, int x) curr = (rStart, cStart - 1);

        int y_lower = Math.Max(0, rStart - 1),
            y_upper = Math.Min(rows, rStart + 2),
            x_lower = Math.Max(0, cStart - 1),
            x_upper = Math.Min(cols, cStart + 2);

        int dir = 0;
        var coords = new int[grid_size][];

        int index = 0;
        while (index < grid_size)
        {
            (int y, int x) pot = (curr.y + dirs[dir].y, curr.x + dirs[dir].x);
            if (pot.y < y_lower || pot.y >= y_upper || pot.x < x_lower || pot.x >= x_upper)
            {
                dir = (dir + 1) % 4;
            }
            else
            {
                curr = pot;
                if (grid[curr.y][curr.x] == 0)
                {
                    grid[curr.y][curr.x] = 1;
                    coords[index] = [curr.y, curr.x];
                    index++;
                }
                if ((y_upper - y_lower) * (x_upper - x_lower) == index)
                {
                    y_lower = Math.Max(0, y_lower - 1);
                    y_upper = Math.Min(rows, y_upper + 1);
                    x_lower = Math.Max(0, x_lower - 1);
                    x_upper = Math.Min(cols, x_upper + 1);
                    if (y_upper - y_lower == 1 || x_upper - x_lower == 1)
                    {
                        dir = (dir + 1) % 4;
                    }
                }
            }
        }

        return coords;
    }
}
