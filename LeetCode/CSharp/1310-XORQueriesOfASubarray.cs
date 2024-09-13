using LeetCode.Shared;

namespace LeetCode.CSharp;

internal class Solution1310 : IRunProgram
{
    public void Run()
    {
        
    }

    public int[] XorQueries(int[] arr, int[][] queries)
    {
        int[] output = new int[queries.Length];

        for (int i = 0; i < queries.Length; i++)
        {
            for (int j = queries[i][0]; j <= queries[i][1]; j++)
            {
                output[i] ^= arr[j];
            }
        }

        return output;
    }
}
