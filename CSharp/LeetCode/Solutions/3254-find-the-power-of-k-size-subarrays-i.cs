using LeetCode.Solutions.Shared;

namespace LeetCode.Solutions;

internal class Solution3254 : IRunProgram
{
    public void Run()
    {
        ResultsArray([1, 2, 3, 4, 3, 2, 5], 3).Print();
        ResultsArray([1, 3, 4], 2).Print();
    }

    public int[] ResultsArray(int[] nums, int k)
    {
        int[] res = new int[nums.Length - k + 1];

        for (int i = 0; i < res.Length; i++)
        {
            bool power = true;
            int max = nums[i];
            for (int j = 0; j < k; j++)
            {
                if (nums[i + j] != max)
                {
                    power = false;
                    break;
                }
                max++;
            }
            if (!power) max = 0;
            res[i] = max - 1;
        }

        return res;
    }
}
