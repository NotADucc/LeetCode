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
        List<int[]> lst = [items[0]];
        for (int i = 1; i < items.Length; i++)
        {
            if (lst[^1][1] < items[i][1])
            {
                if (lst[^1][0] == items[i][0])
                {
                    lst[^1][1] = items[i][1];
                }
                else
                {
                    lst.Add(items[i]);
                }
            }
        }

        for (int i = 0; i < queries.Length; i++)
        {
            int target = queries[i];
            int ind = search(lst, target);
            int res = ind == -1 ? 0 : lst[ind][1];
            queries[i] = res;
        }

        return queries;
    }

    private int search(List<int[]> arr, int target)
    {
        int left = 0, right = arr.Count - 1;

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

        return arr[left][0] <= target ? left : left > 0 && arr[left - 1][0] <= target ? left - 1 : -1;
    }
}
