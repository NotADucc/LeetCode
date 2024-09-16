using LeetCode.Solutions.Shared;

namespace LeetCode.Solutions;

internal class Solution1905 : IRunProgram
{
    public void Run()
    {
        CountSubIslands(
            [[1, 1, 1, 0, 0], [0, 1, 1, 1, 1], [0, 0, 0, 0, 0], [1, 0, 0, 0, 0], [1, 1, 0, 1, 1]],
            [[1, 1, 1, 0, 0], [0, 0, 1, 1, 1], [0, 1, 0, 0, 0], [1, 0, 1, 1, 0], [0, 1, 0, 1, 0]]
        ).Print();
    }

    public int CountSubIslands(int[][] grid1, int[][] grid2)
    {
        int output = 0;

        for (int i = 0; i < grid2.Length; i++)
        {
            for (int j = 0; j < grid2[i].Length; j++)
            {
                if (grid2[i][j] != 1)
                {
                    continue;
                }
                bool island = true;
                Helper(grid1, grid2, i, j, ref island);
                if (island)
                {
                    output++;
                }
            }
        }

        return output;
    }

    private void Helper(int[][] grid1, int[][] grid2, int i, int j, ref bool island)
    {
        if (i < 0 || j < 0 || i >= grid1.Length || j >= grid1[i].Length || grid2[i][j] != 1)
        {
            return;
        }

        if (grid1[i][j] == 0)
        {
            island = false;
        }

        grid2[i][j] = 2;

        Helper(grid1, grid2, i + 1, j, ref island);
        Helper(grid1, grid2, i - 1, j, ref island);
        Helper(grid1, grid2, i, j + 1, ref island);
        Helper(grid1, grid2, i, j - 1, ref island);
    }
}
