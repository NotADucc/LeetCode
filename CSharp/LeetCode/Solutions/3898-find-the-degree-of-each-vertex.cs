using LeetCode.Solutions.Shared;

namespace LeetCode.Solutions;
internal class Solution3898 : IRunProgram
{
    public void Run()
    {

    }

    public int[] FindDegrees(int[][] matrix)
    {
        int n = matrix.Length, m = matrix[0].Length;
        int[] ans = new int[n];
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m; j++)
            {
                ans[i] += matrix[i][j];
            }
        }
        return ans;
    }
}
