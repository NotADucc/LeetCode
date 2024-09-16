using LeetCode.Shared;

namespace LeetCode.CSharp;

public class Solution0059 : IRunProgram
{
    public void Run()
    {
        GenerateMatrix(3).Print();
        GenerateMatrix(1).Print();
    }

    public int[][] GenerateMatrix(int n)
    {
        var grid = new int[n][];

        for (int i = 0; i < n; i++) grid[i] = new int[n];

        int grid_size = n * n;
        int grid_value = 1;

        (int y, int x)[] dirs = [(0, 1), (1, 0), (0, -1), (-1, 0)];
        int y_lower = 0, y_upper = n, x_lower = 0, x_upper = n;
        (int y, int x) curr = (0, -1);
        int dir = 0;

        while (grid_value <= grid_size)
        {
            (int y, int x) pot = (curr.y + dirs[dir].y, curr.x + dirs[dir].x);
            if (pot.y < y_lower || pot.y >= y_upper || pot.x < x_lower || pot.x >= x_upper)
            {
                if (dir == 0)
                {
                    y_lower++;
                }
                else if (dir == 1)
                {
                    x_upper--;
                }
                else if (dir == 2)
                {
                    y_upper--;
                }
                else
                {
                    x_lower++;
                }

                dir = (dir + 1) % 4;
            }
            else
            {
                curr = pot;
                grid[curr.y][curr.x] = grid_value++;
            }
        }

        return grid;
    }
}
