using LeetCode.Solutions.Shared;

namespace LeetCode.Solutions;

internal class Solution2661 : IRunProgram
{
    public void Run()
    {

    }

    public int FirstCompleteIndex(int[] arr, int[][] mat) 
    {
        int n = mat.Length, m = mat[0].Length;
        var dct = new Dictionary<int, (int, int)>();
        int[] r = new int[n];
        int[] c = new int[m];

        for (int i = 0; i < mat.Length; i++)
        {
            for (int j = 0; j < mat[i].Length; j++)
            {
                dct.Add(mat[i][j], (i, j));
            }   
        }

        for (int i = 0; i < arr.Length; i++)
        {
            (int rr, int cc) = dct[arr[i]];
            r[rr]++;
            c[cc]++;
            if (r[rr] == m || c[cc] == n)
                return i;
        }

        return -1;
    }
}
