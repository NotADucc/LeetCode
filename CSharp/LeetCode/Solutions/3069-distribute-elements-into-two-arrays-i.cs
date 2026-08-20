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
        List<int>[] ans = [
            [nums[0]], 
            [nums[1]]
        ];

        for (int i = 2; i < nums.Length; i++)
        {
            int idx = ans[0][^1] > ans[1][^1] ? 0 : 1;
            ans[idx].Add(nums[i]);
        }
        return ans[0]
            .Union(ans[1])
            .ToArray();
    }
}
