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

        var dag = new List<(int, int)>[n * m];
        var res = new int[n * m];

        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < grid[i].Length; j++)
            {
                dag[i * m + j] = new List<(int, int)>();
                res[i * m + j] = int.MaxValue;
                for (int k = 0; k < directions.Length; k++)
                {
                    int new_i = i + directions[k][0], new_j = j + directions[k][1];
                    if (new_i < 0 || new_i >= n || new_j < 0 || new_j >= grid[i].Length) continue;

                    dag[i * m + j].Add((new_i * m + new_j, grid[new_i][new_j]));
                }
            }
        }

        var q = new PriorityQueue<int, int>();
        bool[] visited = new bool[n * m];

        res[0] = 0;
        q.Enqueue(0, 0);

        while (q.Count > 0)
        {
            int curr = q.Dequeue();

            foreach ((int neighbour, int weight) in dag[curr])
            {
                res[neighbour] = Math.Min(res[neighbour], res[curr] + weight);
                if (!visited[neighbour] && neighbour < n * m - 1)
                {
                    visited[neighbour] = true;
                    q.Enqueue(neighbour, res[neighbour]);
                }
            }
        }

        //Console.WriteLine(string.Join("\n", dag.Select(x => string.Join(", ", x))));
        
        //for (int i = 0; i < n; i++)
        //{
        //    for (int j = 0; j < grid[i].Length; j++)
        //    {
        //        Console.Write($"| {res[i * m + j]} |");
        //    }
        //    Console.WriteLine();
        //}
        

        return res[^1];
    }
}
