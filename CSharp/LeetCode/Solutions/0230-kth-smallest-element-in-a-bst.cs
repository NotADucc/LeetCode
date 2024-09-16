using LeetCode.Shared;

namespace LeetCode.CSharp;

internal class Solution0230 : IRunProgram
{
    public void Run()
    {
        KthSmallest(new TreeNode(1), 1);
        KthSmallest(new TreeNode(2, new TreeNode(1)), 1);
    }

    public int KthSmallest(TreeNode root, int k)
    {
        int i = 0, small = int.MaxValue;

        Helper(root, ref i, ref small, k);

        return small;
    }

    public void Helper(TreeNode root, ref int i, ref int small, int k)
    {
        if (root is null)
        {
            return;
        }


        Helper(root.left, ref i, ref small, k);
        i++;
        if (i == k) { small = Math.Min(small, root.val); }
        Helper(root.right, ref i, ref small, k);
    }
}
