using LeetCode.Shared;

namespace LeetCode.CSharp;

internal class Solution1863 : IRunProgram
{
    public void Run()
    {
        SubsetXORSum([1, 3]);
        SubsetXORSum([5, 1, 6]);
    }

    public int SubsetXORSum(int[] nums)
    {
        int output = 0;
        Array.Sort(nums);
        SubsetXORSumHelper(ref output, nums, [], 0);
        return output;
    }

    private void SubsetXORSumHelper(ref int output, int[] nums, List<int> current, int index)
    {
        int xor = 0;
        foreach (var item in current)
        {
            xor ^= item;
        }
        output += xor;

        for (int i = index; i < nums.Length; i++)
        {
            current.Add(nums[i]);
            SubsetXORSumHelper(ref output, nums, current, i + 1);
            current.RemoveAt(current.LastIndexOf(nums[i]));
        }
    }
}
