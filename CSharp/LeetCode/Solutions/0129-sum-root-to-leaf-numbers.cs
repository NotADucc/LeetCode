using LeetCode.Solutions.Shared;

namespace LeetCode.Solutions;

internal class Solution0129 : IRunProgram
{
    public void Run()
    {
        SumNumbers(new TreeNode(1, new TreeNode(1))).Print();
        SumNumbers(new TreeNode(1, new TreeNode(2), new TreeNode(3))).Print();
    }

    public int SumNumbers(TreeNode root)
    {
        if (root.left is null && root.right is null) return root.val;
        return Helper(root.left, root.val) + Helper(root.right, root.val);
    }

    private int Helper(TreeNode root, int curr)
    {
        if (root is null) return 0;
        curr = curr * 10 + root.val;
        if (root.left is null && root.right is null) return curr;
        return Helper(root.left, curr) + Helper(root.right, curr);
    }
}
