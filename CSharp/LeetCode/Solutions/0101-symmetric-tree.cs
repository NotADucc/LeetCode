using LeetCode.Solutions.Shared;

namespace LeetCode.Solutions;

internal class Solution0101 : IRunProgram
{
    public void Run()
    {
        IsSymmetric(new TreeNode(1, new TreeNode(2, new TreeNode(3), new TreeNode(4)), new TreeNode(2, new TreeNode(4), new TreeNode(3)))).Print();
        IsSymmetric(new TreeNode(1, new TreeNode(2, null, new TreeNode(3)), new TreeNode(2, null, new TreeNode(3)))).Print();
    }
    public bool IsSymmetric(TreeNode root)
    {
        return Dfs(root.left, root.right);
    }

    private bool Dfs(TreeNode leftNode, TreeNode rightNode)
    {
        if (leftNode is null || rightNode is null)
        {
            return leftNode == rightNode;
        }

        if (leftNode.val != rightNode.val)
        {
            return false;
        }

        return Dfs(leftNode.left, rightNode.right)
            && Dfs(leftNode.right, rightNode.left);
    }
}
