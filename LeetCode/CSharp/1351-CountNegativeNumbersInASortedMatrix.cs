using LeetCode.Shared;

namespace LeetCode.CSharp;

internal class Solution1351 : IRunProgram
{
    public void Run()
    {
        CountNegatives([[4, 3, 2, -1], [3, 2, 1, -1], [1, 1, -1, -2], [-1, -1, -2, -3]]).Print();
    }
    public int CountNegatives(int[][] grid)
    {
        int output = 0;

        foreach (int[] nums in grid)
        {
            output += nums.Length - GetIndex(nums);
        }

        return output;
    }

    int GetIndex(int[] arr)
    {
        int left = 0, right = arr.Length - 1;
        while (left <= right)
        {
            int m = (left + right) / 2;

            if (int.IsNegative(arr[m]))
            {
                right = m - 1;
            }
            else
            {
                left = m + 1;
            }
        }

        return left;
    }
}
