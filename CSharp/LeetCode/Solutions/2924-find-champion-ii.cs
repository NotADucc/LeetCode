using LeetCode.Solutions.Shared;

namespace LeetCode.Solutions;

internal class Solution2924 : IRunProgram
{
    public void Run()
    {

    }

    public int FindChampion(int n, int[][] edges)
    {
        int[] arr = new int[n];
        foreach (int[] edge in edges)
            arr[edge[1]]++;

        int res = -1;

        for (int i = 0; i < arr.Length; i++)
        {
            int item = arr[i];
            if (item == 0)
            {
                if (res != -1) return -1;
                res = i;
            }
        }

        return res;
    }
}
