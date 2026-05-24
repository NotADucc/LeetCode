using LeetCode.Solutions.Shared;
using System.Diagnostics;

namespace LeetCode.Solutions;
internal class Solution1340 : IRunProgram
{
    public void Run()
    {
        MaxJumps([6, 4, 14, 6, 8, 13, 9, 7, 10, 6, 12], 2).Print();
        MaxJumps([3, 3, 3, 3, 3], 3).Print();
        MaxJumps([7, 6, 5, 4, 3, 2, 1], 1).Print();
    }

    private int[] memo;
    public int MaxJumps(int[] arr, int d)
    {
        int n = arr.Length;
        memo = new int[n];
        int res = 1;

        for (int i = 0; i < n; i++)
        {
            res = Math.Max(res, Jump(arr, d, i));
        }

        return res;
    }
    
    private int Jump(int[] arr, int d, int i) 
    {
        if (memo[i] != 0)
            return memo[i];

        int n = arr.Length;
        int step = 1;

        for (int j = i + 1; j <= Math.Min(n - 1, i + d); j++)
        {
            if (arr[j] >= arr[i])
                break;

            step = Math.Max(step, 1 + Jump(arr, d, j));
        }

        for (int j = i - 1; j >= Math.Max(0, i - d); j--)
        {
            if (arr[j] >= arr[i])
                break;

            step = Math.Max(step, 1 + Jump(arr, d, j));
        }

        memo[i] = step;

        return step;
    }
}
