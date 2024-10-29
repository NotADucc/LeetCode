using LeetCode.Solutions.Shared;

namespace LeetCode.Solutions;

internal class Solution2684 : IRunProgram
{
    public void Run()
    {
        
    }

    public int MaxMoves(int[][] grid)
    {
        Dictionary<(int, int), int> mem = new Dictionary<(int, int), int>();
        int output = 0;
        for (int i = 0; i < grid.Length; i++)
        {
            output = Math.Max(output, DFS(grid, mem, 0, i, 0));
        }
        return output - 1;
    }
    private int DFS(int[][] grid, Dictionary<(int, int), int> mem, int old_val, int i, int j)
    {
        if (i < 0 || i >= grid.Length || j >= grid[i].Length || grid[i][j] <= old_val)
        {
            return 0;
        }
        if (!mem.ContainsKey((i, j)))
        {
            int val = grid[i][j];
            mem[(i, j)] = 1 + Math.Max(DFS(grid, mem, val, i - 1, j + 1), Math.Max(DFS(grid, mem, val, i, j + 1), DFS(grid, mem, val, i + 1, j + 1)));
        }
        return mem[(i, j)];
    }
}
