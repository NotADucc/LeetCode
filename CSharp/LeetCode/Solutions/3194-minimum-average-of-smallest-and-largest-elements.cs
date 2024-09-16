using LeetCode.Solutions.Shared;

namespace LeetCode.Solutions;

internal class Solution3194 : IRunProgram
{
    public void Run()
    {
        MinimumAverage([7, 8, 3, 4, 15, 13, 4, 1]).Print();
    }

    public double MinimumAverage(int[] nums)
    {
        Array.Sort(nums);

        int left = 0, right = nums.Length - 1;
        var min = double.MaxValue;

        while (left < right)
        {
            double avg = (double)(nums[left] + nums[right]) / 2;
            min = Math.Min(min, avg);
            left++;
            right--;
        }

        return min;
    }
}
