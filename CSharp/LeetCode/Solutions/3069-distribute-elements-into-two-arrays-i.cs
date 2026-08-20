using LeetCode.Solutions.Shared;

namespace LeetCode.Solutions;
internal class Solution3069 : IRunProgram
{
    public void Run()
    {
        ResultArray([2, 1, 3]).Print();
        ResultArray([5, 4, 3, 8]).Print();
    }

    public int[] ResultArray(int[] nums)
    {
        List<int>[] arrs = [
            [nums[0]], 
            [nums[1]]
        ];

        for (int i = 2; i < nums.Length; i++)
        {
            int idx = arrs[0][^1] > arrs[1][^1] ? 0 : 1;
            arrs[idx].Add(nums[i]);
        }

        var ans = new int[nums.Length];
        arrs[0].CopyTo(ans, 0);
        arrs[1].CopyTo(ans, arrs[0].Count);

        return ans;
    }
}
