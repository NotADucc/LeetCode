using LeetCode.Solutions.Shared;

namespace LeetCode.Solutions;

internal class Solution0104 : IRunProgram
{
    public void Run()
    {
        MaxDepth(new TreeNode(3, new TreeNode(9), new TreeNode(20, new TreeNode(15), new TreeNode(7)))).Print();
    }

    public int MaxDepth(TreeNode root)
    {
        if (root is null) return 0;
        return 1 + Math.Max(MaxDepth(root.left), MaxDepth(root.right));
    }
}
