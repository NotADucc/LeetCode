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
        Traverse(root, nums, 0);
        nums = nums.OrderBy(o => o).ToList();
        return k > nums.Count ? -1 : nums[^k];
    }

    private void Traverse(TreeNode root, List<long> nums, int curr)
    {
        if (root is null) return;

        if (nums.Count <= curr) nums.Add(root.val);
        else nums[curr] += root.val;

        Traverse(root.left, nums, curr + 1);
        Traverse(root.right, nums, curr + 1);
    }
}
