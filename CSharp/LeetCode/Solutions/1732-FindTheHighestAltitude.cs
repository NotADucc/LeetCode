using LeetCode.Shared;

namespace LeetCode.CSharp;

internal class Solution1732 : IRunProgram
{
    public void Run()
    {
        LargestAltitude([-5, 1, 5, 0, -7]).Print();
    }

    public int LargestAltitude(int[] gain)
    {
        int max = 0, curr = 0;
        for (int i = 0; i < gain.Length; i++)
        {
            curr += gain[i];
            if (curr > max)
            {
                max = curr;
            }
        }
        return max;
    }
}
