using LeetCode.Solutions.Shared;

namespace LeetCode.Solutions;
internal class Solution3731 : IRunProgram
{
    public void Run()
    {
        FindMissingElements([1, 4, 2, 5]).Print();
        FindMissingElements([7, 8, 6, 9]).Print();
        FindMissingElements([5, 1]).Print();

    }
    public IList<int> FindMissingElements(int[] nums)
    {
        List<int> ans = new List<int>();
        Array.Sort(nums);
        int min = nums[0], max = nums[nums.Length - 1], idx = 0;

        for (int i = min; i < max; i++)
        {
            int num = nums[idx];
            if (num > i)
                ans.Add(i);
            else
                idx++;
        }

        return ans;
    }
}
