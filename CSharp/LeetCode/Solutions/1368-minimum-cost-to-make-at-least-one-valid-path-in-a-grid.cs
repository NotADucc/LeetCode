using LeetCode.Solutions.Shared;

namespace LeetCode.Solutions;

internal class Solution1368 : IRunProgram
{
    public void Run()
    {

    }

    private int[][] dirs = [[], [0, 1], [0, -1], [1, 0], [-1, 0]];
    public int MinCost(int[][] grid)
    {
        int[] end = [grid.Length - 1, grid[0].Length - 1];
        var q = new PriorityQueue<(int i, int j, int dir, int cost), int>();
        q.Enqueue((0, 0, grid[0][0], 0), 0);
        // i, j, dir
        var visited = new HashSet<(int i, int j, int dir)>();

        while (q.Count > 0)
        {
            var deq = q.Dequeue();

            if (end[0] == deq.i && end[1] == deq.j)
            {
                return deq.cost;
            }

            for (int d = 1; d < dirs.Length; d++)
            {
                int new_i = deq.i + dirs[d][0];
                int new_j = deq.j + dirs[d][1];

                if (new_i < 0 || new_j < 0 || new_i >= grid.Length || new_j >= grid[0].Length || !visited.Add((new_i, new_j, d)))
                {
                    continue;
                }
                int cost = deq.dir == d ? deq.cost : deq.cost + 1;
                q.Enqueue((new_i, new_j, grid[new_i][new_j], cost), cost);
            }
        }

        return -1;
    }
}
