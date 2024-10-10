using LeetCode.Solutions.Shared;

namespace LeetCode.Solutions;

internal class Solution0962 : IRunProgram
{
    public void Run()
    {
		
    }

    public int MaxWidthRamp(int[] nums) 
    {   
        int output = 0;
        for(int i = 0; i <nums.Length; i++)
        {
            if (output >= nums.Length - i) break;
            for(int j = i + 1; j < nums.Length; j++)
            {
                if (nums[i] <= nums[j])
                {
                    output = Math.Max(output, j - i);
                }
            }
        }
        return output;
    }
}
