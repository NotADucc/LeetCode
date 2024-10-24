using LeetCode.Solutions.Shared;

namespace LeetCode.Solutions;

internal class Solution0951 : IRunProgram
{
    public void Run()
    {

    }

    public bool FlipEquiv(TreeNode root1, TreeNode root2) 
    {
        if (root1 is null ^ root2 is null) return false;
        if (root1 is null && root2 is null) return true;
        if (root1.val != root2.val) return false;

        return 
            (FlipEquiv(root1.left, root2.left) && FlipEquiv(root1.right, root2.right))
            || (FlipEquiv(root1.left, root2.right) && FlipEquiv(root1.right, root2.left));
    }
}
