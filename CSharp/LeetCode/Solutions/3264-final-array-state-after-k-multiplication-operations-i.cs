using LeetCode.Solutions.Shared;

namespace LeetCode.Solutions;

internal class Solution3264 : IRunProgram
{
    public void Run()
    {

    }
    public int[] GetFinalState(int[] nums, int k, int multiplier)
    {
        int Smallest(int[] arr)
        {
            int idx = 0, small = int.MaxValue;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] < small)
                {
                    small = arr[i];
                    idx = i;
                }
            }
            return idx;
        }

        for (int i = 0; i < k; i++)
        {
            int idx = Smallest(nums);
            nums[idx] *= multiplier;
        }

        return nums;
    }
}
