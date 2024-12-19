using LeetCode.Solutions.Shared;

namespace LeetCode.Solutions;

internal class Solution0769 : IRunProgram
{
    public void Run()
    {
        MaxChunksToSorted([4, 3, 2, 1, 0]).Print();
        MaxChunksToSorted([1, 0, 2, 3, 4]).Print();
        MaxChunksToSorted([0, 2, 1]).Print();
        MaxChunksToSorted([0, 2, 4, 3, 1, 9, 5, 6, 7, 8]).Print();
    }

    public int MaxChunksToSorted(int[] arr)
    {
        int res = 0, max = 0;

        for (int i = 0; i < arr.Length; i++)
        {
            max = Math.Max(max, arr[i]);

            if (max == i)
            {
                res++;
            }
        }

        return res;
    }
}
