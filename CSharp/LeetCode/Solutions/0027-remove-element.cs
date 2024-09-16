using LeetCode.Solutions.Shared;

namespace LeetCode.Solutions;

internal class Solution0027: IRunProgram
{
    public void Run()
    {
        RemoveElement([1, 1, 2], 2).Print();
        RemoveElement([3, 2, 2, 3], 3).Print();
        RemoveElement([0, 1, 2, 2, 3, 0, 4, 2], 2).Print();
    }

    public int RemoveElement(int[] nums, int val)
    {
        int j = 0;
        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] != val)
            {
                nums[j] = nums[i];
                j++;
            }
        }
        return j;
    }
}
