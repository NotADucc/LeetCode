using LeetCode.Solutions.Shared;

namespace LeetCode.Solutions;

internal class Solution0980: IRunProgram
{
    public void Run()
    {
        UniquePathsIII([[1, 0, 0, 0], [0, 0, 0, 0], [0, 0, 2, -1]]).Print();
    }

    public int UniquePathsIII(int[][] grid)
    {
        int obstacle_count = 0;
        int total_count = grid.Length * grid[0].Length;
        (int, int) start = (0, 0);
        for (int i = 0; i < grid.Length; i++)
        {
            for (int j = 0; j < grid[i].Length; j++)
            {
                if (grid[i][j] != 0)
                {
                    if (grid[i][j] == 1)
                    {
                        start = (i, j);
                    }
                    obstacle_count++;
                }
            }
        }

        int output = 0;

        Helper(grid, total_count, obstacle_count, 0, ref output, start.Item1, start.Item2);

        return output;
    }

    private void Helper(int[][] grid, int total_tiles, int obstacle_count, int current_moves, ref int output, int i, int j)
    {
        if (i < 0 || j < 0 || i >= grid.Length || j >= grid[i].Length || grid[i][j] == -1)
        {
            return;
        }

        if (grid[i][j] == 2)
        {
            if (total_tiles - obstacle_count < current_moves)
            {
                output++;
            }
        }
        else
        {
            if (grid[i][j] == 5)
            {
                return;
            }

            int old = grid[i][j];
            grid[i][j] = 5;

            Helper(grid, total_tiles, obstacle_count, current_moves + 1, ref output, i - 1, j);
            Helper(grid, total_tiles, obstacle_count, current_moves + 1, ref output, i + 1, j);
            Helper(grid, total_tiles, obstacle_count, current_moves + 1, ref output, i, j - 1);
            Helper(grid, total_tiles, obstacle_count, current_moves + 1, ref output, i, j + 1);

            grid[i][j] = old;
        }
    }
}
