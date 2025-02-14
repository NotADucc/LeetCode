using LeetCode.Solutions.Shared;

namespace LeetCode.Solutions;

internal class Solution3151 : IRunProgram
{
    public void Run()
    {

    }
    public bool IsArraySpecial(int[] nums)
    {
        bool IsEven(int num) => (num & 1) == 0;
        for (int i = 0; i < nums.Length - 1; i++)
        {
            if (IsEven(nums[i]) == IsEven(nums[i + 1]))
            {
                return false;
            }
        }
        return true;
    }
}
