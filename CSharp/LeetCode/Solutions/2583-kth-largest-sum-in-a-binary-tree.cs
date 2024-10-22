using LeetCode.Solutions.Shared;

namespace LeetCode.Solutions;

internal class Solution2583 : IRunProgram
{
    public void Run()
    {
        
    }

    public long KthLargestLevelSum(TreeNode root, int k)
    {
        var nums = new List<long>();
        int depth = 0;
        Traverse(root, nums, ref depth, 0);
        nums = nums.OrderBy(o => o).ToList();
        return k > nums.Count ? -1 : nums[^k];
    }

    private void Traverse(TreeNode root, List<long> nums, ref int max, int curr)
    {
        if (root is null) return;

        max = Math.Max(max, curr);
        if (nums.Count <= curr) nums.Add(root.val);
        else nums[curr] += root.val;

        Traverse(root.left, nums, ref max, curr + 1);
        Traverse(root.right, nums, ref max, curr + 1);
    }
}
