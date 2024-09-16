using LeetCode.Solutions.Shared;

namespace LeetCode.Solutions;

internal class Solution0463 : IRunProgram
{
    public void Run()
    {
        IslandPerimeter([[0, 1, 0, 0], [1, 1, 1, 0], [0, 1, 0, 0], [1, 1, 0, 0]]).Print();
        IslandPerimeter([[1]]).Print();
        IslandPerimeter([[1, 0]]).Print();
    }

    public int IslandPerimeter(int[][] grid)
    {
        int output = 0;

        for (int i = 0; i < grid.Length; i++)
        {
            for (int j = 0; j < grid[i].Length; j++)
            {
                if (grid[i][j] != 1)
                {
                    continue;
                }

                int sides = 4;
                if (i - 1 >= 0)
                {
                    sides = grid[i - 1][j] == 1 ? sides - 1 : sides;
                }

                if (i + 1 < grid.Length)
                {
                    sides = grid[i + 1][j] == 1 ? sides - 1 : sides;
                }

                if (j - 1 >= 0)
                {
                    sides = grid[i][j - 1] == 1 ? sides - 1 : sides;
                }

                if (j + 1 < grid[i].Length)
                {
                    sides = grid[i][j + 1] == 1 ? sides - 1 : sides;
                }
                output += sides;
            }
        }

        return output;
    }
}
