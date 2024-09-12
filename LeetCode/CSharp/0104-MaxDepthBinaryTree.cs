using LeetCode.Shared;

namespace LeetCode.CSharp;

internal class Solution0104 : IRunProgram
{
    public void Run()
    {
        MaxDepth(new TreeNode(3, new TreeNode(9), new TreeNode(20, new TreeNode(15), new TreeNode(7)))).Print();
    }

    public int MaxDepth(TreeNode root)
    {
        int max = 0;
        Helper(root, ref max);
        return max;
    }

    private void Helper(TreeNode root, ref int max, int curr = 0)
    {
        if (root is null)
        {
            return;
        }

        curr++;
        max = Math.Max(max, curr);

        Helper(root.left, ref max, curr);
        Helper(root.right, ref max, curr);
    }
}
