using LeetCode.Shared;

namespace LeetCode.CSharp;

internal class Solution0695 : IRunProgram
{
    public void Run()
    {
        MaxAreaOfIsland([[0, 0, 1, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0], [0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 0, 0, 0], [0, 1, 1, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0], [0, 1, 0, 0, 1, 1, 0, 0, 1, 0, 1, 0, 0], [0, 1, 0, 0, 1, 1, 0, 0, 1, 1, 1, 0, 0], [0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0], [0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 0, 0, 0], [0, 0, 0, 0, 0, 0, 0, 1, 1, 0, 0, 0, 0]]).Print();
        MaxAreaOfIsland([[0, 0, 0, 0, 0, 0, 0, 0]]);
    }
    public int MaxAreaOfIsland(int[][] grid)
    {
        int max = 0;

        for (int i = 0; i < grid.Length; i++)
        {
            for (int j = 0; j < grid[i].Length; j++)
            {
                if (grid[i][j] != 1)
                {
                    continue;
                }
                int current_count = 0;
                Helper(grid, i, j, ref current_count);
                max = Math.Max(max, current_count);
            }
        }

        return max;
    }

    private void Helper(int[][] grid, int i, int j, ref int current_count)
    {
        if (i < 0 || j < 0 || i >= grid.Length || j >= grid[i].Length || grid[i][j] != 1)
        {
            return;
        }

        grid[i][j] = 2;
        current_count++;

        Helper(grid, i - 1, j, ref current_count);
        Helper(grid, i + 1, j, ref current_count);
        Helper(grid, i, j - 1, ref current_count);
        Helper(grid, i, j + 1, ref current_count);
    }
}
