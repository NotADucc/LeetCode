using LeetCode.Solutions.Shared;

namespace LeetCode.Solutions;

internal class Solution1402 : IRunProgram
{
    public void Run()
    {
        MaxSatisfaction([-1, -8, 0, 5, -9]).Print();
    }
    public int MaxSatisfaction(int[] satisfaction)
    {
        Array.Sort(satisfaction);
        int output = 0;

        for (int i = 0; i < satisfaction.Length; i++)
        {
            int temp = 0, k = 1;
            for (int j = i; j < satisfaction.Length; j++)
            {
                temp += (k++) * satisfaction[j];
            }
            output = Math.Max(output, temp);
        }

        return output;
    }
}
