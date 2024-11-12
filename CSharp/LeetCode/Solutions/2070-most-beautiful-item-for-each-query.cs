using LeetCode.Solutions.Shared;

namespace LeetCode.Solutions;

internal class Solution2070 : IRunProgram
{
    public void Run()
    {
        MaximumBeauty([[1, 2], [3, 2], [2, 4], [5, 6], [3, 5]], [4, 5, 6]).Print();
        MaximumBeauty([[1, 2], [1, 7], [1, 3], [1, 4]], [1]).Print();
    }
    public int[] MaximumBeauty(int[][] items, int[] queries)
    {
        Array.Sort(items, (a, b) => a[0] - b[0]);
        for (int i = 1; i < items.Length; i++)
        {
            items[i][1] = Math.Max(items[i - 1][1], items[i][1]);
        }

        for (int i = 0; i < queries.Length; i++)
        {
            int target = queries[i];
            int ind = search(items, target);
            int res = ind == -1 ? 0 : items[ind][1];
            queries[i] = res;
        }

        return queries;
    }

    private int search(int[][] arr, int target)
    {
        int left = 0, right = arr.Length - 1;

        while (left < right)
        {
            int mid = (left + right) >> 1;

            if (arr[mid][0] <= target)
            {
                left = mid + 1;
            }
            else
            {
                right = mid;
            }
        }

        return arr[left][0] <= target ? left : --left;
    }
}
