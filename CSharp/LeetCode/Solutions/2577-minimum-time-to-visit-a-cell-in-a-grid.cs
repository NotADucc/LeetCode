using LeetCode.Solutions.Shared;

namespace LeetCode.Solutions;

internal class Solution2577 : IRunProgram
{
    public void Run()
    {

    }

    public int MinimumTime(int[][] grid)
    {
        if (grid[0][1] > 1 && grid[1][0] > 1)
            return -1;
        int ROWS = grid.Length, COLS = grid[0].Length;

        int[] directions = [0, 1, 0, -1, 0];

        // row, col, new_rime | new_rime
        var q = new PriorityQueue<(int, int, int), int>();
        var visited = new bool[ROWS, COLS];
        q.Enqueue((0, 0, 0), 0);

        while (q.Count > 0)
        {
            (int row, int col, int time) = q.Dequeue();
            if (row == ROWS - 1 && col == COLS - 1)
                return time;

            for (int i = 0; i < 4; i++)
            {
                int new_row = row + directions[i], new_col = col + directions[i + 1];
                if (new_row < 0 || new_row >= ROWS || new_col < 0 || new_col >= COLS)
                    continue;

                int cost = grid[new_row][new_col];
                int new_rime = Math.Max(time + 1, cost);
                new_rime += (new_rime & 1) ^ ((new_row + new_col) & 1);
                if (!visited[new_row, new_col])
                {
                    visited[new_row, new_col] = true;
                    q.Enqueue((new_row, new_col, new_rime), new_rime);
                }
            }
        }

        return -1;
    }
}
