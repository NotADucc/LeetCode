using LeetCode.Shared;

namespace LeetCode.CSharp;

internal class Solution1310 : IRunProgram
{
    public void Run()
    {
        XorQueries([1, 3, 4, 8], [[0, 1], [1, 2], [0, 3], [3, 3]]).Print();
    }

    public int[] XorQueries(int[] arr, int[][] queries)
    {
        int[] output = new int[queries.Length];
        for (int i = 1; i < arr.Length; i++)
        {
            arr[i] ^= arr[i - 1] ^ arr[i];
        }
        for (int i = 0; i < queries.Length; i++)
        {
            var q1 = queries[i][0];
            var q2 = queries[i][1];
            output[i] = arr[q2];
            if (q1 > 0)
            {
                output[i] ^= arr[q1 - 1];
            }
        }

        return output;
    }
}
