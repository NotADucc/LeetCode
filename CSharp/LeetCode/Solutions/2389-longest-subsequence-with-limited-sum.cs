using LeetCode.Shared;

namespace LeetCode.CSharp;

internal class Solution2389 : IRunProgram
{
    public void Run()
    {
        AnswerQueries([4, 5, 2, 1], [3, 10, 21]).Print();
    }
    public int[] AnswerQueries(int[] nums, int[] queries)
    {
        Array.Sort(nums);
        for (int i = 1; i < nums.Length; i++)
        {
            nums[i] += nums[i - 1];
        }

        for (int i = 0; i < queries.Length; i++)
        {
            queries[i] = Helper(nums, queries[i]);
        }
        return queries;
    }

    private int Helper(int[] arr, int target)
    {
        int left = 0, right = arr.Length - 1;
        while (left <= right)
        {
            int mid = (left + right) >> 1;
            if (arr[mid] < target)
            {
                left = mid + 1;
            }
            else if (arr[mid] > target)
            {
                right = mid - 1;
            }
            else
            {
                return mid + 1;
            }
        }
        return left;
    }
}
