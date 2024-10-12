using LeetCode.Solutions.Shared;

namespace LeetCode.Solutions;

internal class Solution3314 : IRunProgram
{
    public void Run()
    {

    }

    public int[] MinBitwiseArray(IList<int> nums)
    {
        int[] output = new int[nums.Count];

        for (int i = 0; i < nums.Count; i++)
        {
            int num = nums[i];
            if ((num & 1) == 0)
            { 
                output[i] = -1;
                continue;
            }
            for (int j = 31; j >= 0; j--)
            {
                int shift = 1 << j;
                if (shift > num) continue;
                int temp = num - shift;
                int or = temp | (temp + 1);
                if (or != num) continue;

                output[i] = temp;
                break;
            }
        }

        return output;
    }
}
