using LeetCode.Shared;

namespace LeetCode.CSharp;

internal class Solution1894 : IRunProgram
{
    public void Run()
    {
        ChalkReplacer([5, 1, 5], 22).Print();
    }

    public int ChalkReplacer(int[] chalk, int k)
    {
        (int[] sum, int len) = SumArr(chalk);

        if (len == chalk.Length)
        {
            k %= sum[^1];
        }

        int i = Search(sum, len, k);

        return chalk[i] <= k ? i + 1 : i;
    }

    private (int[], int) SumArr(int[] input)
    {
        for (int i = 1; i < input.Length; i++)
        {
            if (input[i] + input[i - 1] != (long)input[i] + input[i - 1])
            {
                return (input, i);
            }
            input[i] = input[i] + input[i - 1];
        }

        return (input, input.Length);
    }

    private int Search(int[] arr, int len, int target)
    {
        int left = 0, right = len - 1;

        while (left <= right)
        {
            int mid = (left + right) >> 1;
            if (arr[mid] == target)
            {
                return mid;
            }
            else if (arr[mid] < target)
            {
                left = mid + 1;
            }
            else
            {
                right = mid - 1;
            }
        }

        return left;
    }
}
