using LeetCode.Shared;

namespace LeetCode.CSharp;

internal class Solution1219 : IRunProgram
{
    public void Run()
    {
        GetMaximumGold([[0, 6, 0], [5, 8, 7], [0, 9, 0]]).Print();
    }
    public int GetMaximumGold(int[][] grid)
    {
        int output = 0;

        for (int i = 0; i < grid.Length; i++)
        {
            for (int j = 0; j < grid[i].Length; j++)
            {
                if (grid[i][j] <= 0)
                {
                    continue;
                }

                Helper(grid, i, j, ref output, 0);
            }
        }

        return output;
    }

    private void Helper(int[][] grid, int i, int j, ref int output, int current)
    {
        if (i < 0 || j < 0 || i >= grid.Length || j >= grid[i].Length || grid[i][j] <= 0)
        {
            return;
        }

        int grid_val = grid[i][j];
        current += grid_val;
        output = Math.Max(output, current);

        grid[i][j] = -1;
        Helper(grid, i - 1, j, ref output, current);
        Helper(grid, i + 1, j, ref output, current);
        Helper(grid, i, j - 1, ref output, current);
        Helper(grid, i, j + 1, ref output, current);
        grid[i][j] = grid_val;
    }
}
