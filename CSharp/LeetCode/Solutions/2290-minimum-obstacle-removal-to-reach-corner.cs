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

        var res = new int[n * m];
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < grid[i].Length; j++)
            {
                res[i * m + j] = int.MaxValue;
            }
        }

        var q = new PriorityQueue<(int, int), int>();
        bool[] visited = new bool[n * m];

        res[0] = 0;
        q.Enqueue((0, 0), 0);

        while (q.Count > 0)
        {
            (int i, int j) = q.Dequeue();
            for (int k = 0; k < directions.Length; k++)
            {
                int new_i = i + directions[k][0], new_j = j + directions[k][1];
                if (new_i < 0 || new_i >= n || new_j < 0 || new_j >= grid[i].Length) continue;

                res[new_i * m + new_j] = Math.Min(res[new_i * m + new_j], res[i * m + j] + grid[new_i][new_j]);
                if (!visited[new_i * m + new_j])
                {
                    visited[new_i * m + new_j] = true;
                    q.Enqueue((new_i, new_j), res[new_i * m + new_j]);
                }
            }
        }

        /*
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < grid[i].Length; j++)
            {
                Console.Write($"| {res[i * m + j]} |");
            }
            Console.WriteLine();
        }
        */

        return res[^1];
    }
}
