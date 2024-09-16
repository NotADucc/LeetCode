using LeetCode.Solutions.Shared;

namespace LeetCode.Solutions;

internal class Solution2419 : IRunProgram
{
    public void Run()
    {
        LongestSubarray([1, 2, 3, 3, 2, 2]).Print();
        LongestSubarray([1, 2, 3, 4]).Print();
        LongestSubarray([311155, 311155, 311155, 311155, 311155, 311155, 311155, 311155, 201191, 311155]).Print();
    }

    public int LongestSubarray(int[] nums)
    {
        int output = 0, current = 0, AND = nums[0];
        for (int i = 0; i < nums.Length; i++)
        {
            current = (nums[i] & AND) == AND ? current + 1 : 0;

            if (nums[i] > AND)
            {
                AND = nums[i];
                output = 1;
                current = 1;
            }
            else
            {
                output = Math.Max(output, current);
            }
        }
        return output;
    }

    public int LongestSubarray_Max(int[] nums)
    {
        int output = 0, current = 0, AND = nums.Max();
        for (int i = 0; i < nums.Length; i++)
        {
            current = (nums[i] & AND) == AND ? current + 1 : 0;
            output = Math.Max(output, current);
        }
        return output;
    }
}
