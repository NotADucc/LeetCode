using LeetCode.Solutions.Shared;

namespace LeetCode.Solutions;

internal class Solution1277 : IRunProgram
{
    public void Run()
    {

    }

    Dictionary<(int, int), int> mem = new Dictionary<(int, int), int>();
    public int CountSquares(int[][] matrix)
    {
        int output = 0;
        for (int i = 0; i < matrix.Length; i++)
        {
            for (int j = 0; j < matrix[i].Length; j++)
            {
                output += DFS(matrix, i, j);
            }
        }

        return output;
    }

    private int DFS(int[][] matrix, int i, int j)
    {
        if (i >= matrix.Length || j >= matrix[i].Length || matrix[i][j] == 0) return 0;
        if (!mem.ContainsKey((i, j))) mem[(i, j)] = Math.Min(DFS(matrix, i + 1, j), Math.Min(DFS(matrix, i, j + 1), DFS(matrix, i + 1, j + 1))) + 1;
        return mem[(i, j)];
    }
}
