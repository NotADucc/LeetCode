using LeetCode.Solutions.Shared;

namespace LeetCode.Solutions;

internal class Solution1014 : IRunProgram
{
    public void Run()
    {

    }

    public int MaxScoreSightseeingPair(int[] values)
    {
        int max_left = values[0], max = 0;

        for (int i = 1; i < values.Length; i++)
        {
            int right = values[i] - i;
            int left = values[i] + i;
            max = Math.Max(max, max_left + right);
            max_left = Math.Max(max_left, left);
        }

        return max;
    }
}
