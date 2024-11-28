using LeetCode.Solutions.Shared;

namespace LeetCode.Solutions;

internal class Solution2290 : IRunProgram
{
    public void Run()
    {
        MinimumObstacles([[0, 1, 0, 0, 0], [0, 1, 0, 1, 0], [0, 0, 0, 1, 0]]).Print();
    }

    private readonly int[][] directions = [[0, 1], [0, -1], [1, 0], [-1, 0]];
    public int MinimumObstacles(int[][] grid)
    {
        int n = grid.Length, m = grid[0].Length;

        var res = new int[n, m];
        for (int i = 0; i < n; i++)
            for (int j = 0; j < grid[i].Length; j++)
                res[i, j] = int.MaxValue;


        var q = new LinkedList<(int, int)>();

        res[0, 0] = 0;
        q.AddFirst((0, 0));

        while (q.Count > 0)
        {
            (int i, int j) = q.First!.Value;
            q.RemoveFirst();
            for (int k = 0; k < directions.Length; k++)
            {
                int new_i = i + directions[k][0], new_j = j + directions[k][1];
                if (new_i < 0 || new_i >= n || new_j < 0 || new_j >= grid[i].Length) continue;

                if (res[new_i, new_j] > res[i, j] + grid[new_i][new_j])
                {
                    res[new_i, new_j] = res[i, j] + grid[new_i][new_j];
                    if (res[new_i, new_j] == 0)
                    {
                        q.AddFirst((new_i, new_j));
                    }
                    else
                    {
                        q.AddLast((new_i, new_j));
                    }
                }
            }
        }

        return res[n - 1, m - 1];
    }
}
