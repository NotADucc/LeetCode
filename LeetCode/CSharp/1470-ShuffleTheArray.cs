using LeetCode.Shared;

namespace LeetCode.CSharp;

internal class Solution1470 : IRunProgram
{
    public void Run()
    {
        Shuffle([2, 5, 1, 3, 4, 7], 3).Print();
    }
    public int[] Shuffle(int[] nums, int n)
    {
        int[] output = new int[nums.Length];
        for (int i = 0, j = n; i < nums.Length; i+=2, j++)
        {
            output[i] = nums[j - n];
            output[i + 1] = nums[j];
        }
        return output;
    }
}
