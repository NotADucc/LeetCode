using LeetCode.Shared;

namespace LeetCode.CSharp;

internal class Solution0169 : IRunProgram
{
    public void Run()
    {
        MajorityElement([3, 2, 3]).Print();
        MajorityElement([2, 2, 1, 1, 1, 2, 2]).Print();
    }
    public int MajorityElement(int[] nums)
    {
        Array.Sort(nums);
        int t = nums[0];
        int c = 0;
        for (int i = 0; i < nums.Length; i++)
        {
            if (t - nums[i] == 0)
            {
                c++;
                if (c > nums.Length / 2)
                {
                    return nums[i];
                }
                continue;
            }
            c = 1;
            t = nums[i];
        }
        return t;
    }
}
