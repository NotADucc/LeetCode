using LeetCode.Solutions.Shared;

namespace LeetCode.Solutions;

internal class Solution0080 : IRunProgram
{
    public void Run()
    {
        RemoveDuplicates([1, 1, 1, 2, 2, 3]);
    }

    public int RemoveDuplicates(int[] nums)
    {
        int l = 0, r = 1;

        int output = nums.Length;

        while (r < nums.Length)
        {
            if (nums[l] == nums[r])
            {
                r++;
            }
            else
            {
                if (r - l <= 2)
                {
                    l = r;
                    r = l;
                }
                else
                {
                    output -= (r - l) - 2;

                    if (nums[l] > nums[r])
                    {
                        l = 0; r = 0;
                        break;
                    }


                    l += 2;

                    for (int i = r, j = l; i < nums.Length; i++, j++)
                    {
                        nums[j] = nums[i];
                    }

                    for (int i = nums.Length - 1; i >= output; i--)
                    {
                        nums[i] = int.MinValue;
                    }

                    r = l;
                }
            }
        }

        if (r - l > 2 && nums[^1] != int.MinValue) { output -= (r - l) - 2; }

        return output;
    }
}
