using LeetCode.Shared;

namespace LeetCode.CSharp;

internal class Solution0905: IRunProgram
{
    public void Run()
    {
        SortArrayByParity([3, 1, 2, 4]).Print();
    }
    public int[] SortArrayByParity(int[] nums)
    {
        int left = 0, right = nums.Length - 1;

        while (left < right)
        {
            if (IsEven(nums[left]))
            {
                left++;
            }
            else
            {
                if (IsEven(nums[right]))
                {
                    var temp = nums[left];
                    nums[left] = nums[right];
                    nums[right] = temp;
                }
            }
            if (!IsEven(nums[right]))
            {
                right--;
            }
            else
            {
                if (!IsEven(nums[left]))
                {
                    var temp = nums[left];
                    nums[left] = nums[right];
                    nums[right] = temp;
                }
            }
        }

        return nums;
    }

    public bool IsEven(int input) => (input & 1) == 0;
}
