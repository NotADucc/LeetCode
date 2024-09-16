using LeetCode.Solutions.Shared;

namespace LeetCode.Solutions;

internal class Solution2022 : IRunProgram
{
    public void Run()
    {
        Construct2DArray([1, 2, 3, 4], 2, 2).Print();
    }
    public int[][] Construct2DArray(int[] original, int m, int n)
    {
        if (m * n != original.Length)
        {
            return [];
        }

        var output = new int[m][];
        int k = 0;
        for (int i = 0; i < m; i++)
        {
            output[i] = new int[n];
            for (int j = 0; j < n; j++)
            {
                output[i][j] = original[k++];
            }
        }

        return output;
    }
}
