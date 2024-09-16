using LeetCode.Solutions.Shared;

namespace LeetCode.Solutions;

internal class Solution0100 : IRunProgram
{
    public void Run()
    {
        IsSameTree(new TreeNode(1, new TreeNode(2), new TreeNode(3)), new TreeNode(1, new TreeNode(2), new TreeNode(3))).Print();
        IsSameTree(new TreeNode(1, new TreeNode(2)), new TreeNode(1, new TreeNode(2), new TreeNode(3))).Print();
    }
    public bool IsSameTree(TreeNode p, TreeNode q)
    {
        if (p is null ^ q is null)
        {
            return false;
        }
        if (p is null && q is null)
        {
            return true;
        }
        if (p.val != q.val)
        {
            return false;
        }
        return IsSameTree(p.left, q.left) && IsSameTree(p.right, q.right);
    }
}
