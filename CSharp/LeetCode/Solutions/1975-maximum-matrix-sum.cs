using LeetCode.Solutions.Shared;

namespace LeetCode.Solutions;

internal class Solution1975 : IRunProgram
{
    public void Run()
    {
        
    }

    public long MaxMatrixSum(int[][] matrix)
    {
        long res = 0;
        int negative = 0, smallest = int.MaxValue;
        for (int i = 0; i < matrix.Length; i++)
        {
            for (int j = 0; j < matrix.Length; j++)
            {
                if (matrix[i][j] < 0)
                {
                    matrix[i][j] *= -1;
                    negative++;
                }
                smallest = Math.Min(smallest, matrix[i][j]);
                res += matrix[i][j];
            }
        }

        return (negative & 1) == 1 ? res - (smallest << 1) : res;
    }
}
