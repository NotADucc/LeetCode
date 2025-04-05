using LeetCode.Solutions.Shared;

namespace LeetCode.Solutions;

internal class Solution1863 : IRunProgram
{
    public void Run()
    {
        SubsetXORSum([1, 3]);
        SubsetXORSum([5, 1, 6]);
    }

    public int SubsetXORSum(int[] nums)
        => SubsetXORSumHelper(0, nums, [], 0);

    private int SubsetXORSumHelper(int output, int[] nums, List<int> current, int index)
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
            output = SubsetXORSumHelper(output, nums, current, i + 1);
            current.RemoveAt(current.LastIndexOf(nums[i]));
        }
        return output;
    }
}
