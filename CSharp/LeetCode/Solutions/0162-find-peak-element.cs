using LeetCode.Solutions.Shared;

namespace LeetCode.Solutions;

internal class Solution0162 : IRunProgram
{
    public void Run()
    {
        FindPeakElement([1, 2, 3, 1]).Print();
        FindPeakElement([1, 2, 1, 3, 5, 6, 4]).Print();
    }

    public int FindPeakElement(int[] nums)
    {
        for (int i = 0; i < nums.Length - 1; i++)
        {
            if (nums[i] > nums[i + 1])
            {
                return i;
            }
        }

        return nums.Length - 1;
    }
}
