using LeetCode.Solutions.Shared;

namespace LeetCode.Solutions;
internal class Solution1534 : IRunProgram
{
    public void Run()
    {

    }
    public int CountGoodTriplets(int[] arr, int a, int b, int c)
    {
        int res = 0, n = arr.Length;
        for (int i = 0; i < n; i++)
        {
            for (int j = i + 1; j < n; j++)
            {
                for (int k = j + 1; k < n; k++)
                {
                    int ij = Math.Abs(arr[i] - arr[j]);
                    int jk = Math.Abs(arr[j] - arr[k]);
                    int ik = Math.Abs(arr[i] - arr[k]);
                    if (ij <= a && jk <= b && ik <= c) res++;
                }
            }
        }
        return res;
    }
}
