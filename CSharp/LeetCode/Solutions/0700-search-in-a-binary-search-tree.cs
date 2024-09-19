using LeetCode.Solutions.Shared;

namespace LeetCode.Solutions;

internal class Solution0700 : IRunProgram
{
    public void Run()
    {

    }

    public TreeNode SearchBST(TreeNode root, int val)
    {
        if (root is null) return null;

        if (root.val == val) return root;

        return root.val > val ? SearchBST(root.left, val) : SearchBST(root.right, val);
    }

    public TreeNode SearchBSTBad(TreeNode root, int val)
    {
        if (root is null) return null;

        if (root.val == val) return root;

        return SearchBST(root.left, val) ?? SearchBST(root.right, val);
    }
}
