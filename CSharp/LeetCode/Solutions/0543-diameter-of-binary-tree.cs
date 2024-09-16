using BenchmarkDotNet.Disassemblers;
using LeetCode.Shared;

namespace LeetCode.CSharp;

internal class Solution0543 : IRunProgram
{
    public void Run()
    {
        DiameterOfBinaryTree(new TreeNode(1, new TreeNode(2), new TreeNode(3))).Print();
    }

    public int DiameterOfBinaryTree(TreeNode root)
    {
        if (root is null) return 0;
        int curr_width = Helper(root.left, 0) + Helper(root.right, 0);
        return Math.Max(curr_width, Math.Max(DiameterOfBinaryTree(root.left), DiameterOfBinaryTree(root.right)));
    }

    public int Helper(TreeNode root, int depth)
    {
        if (root is null) return 0;
        return Math.Max(Helper(root.left, depth + 1), Helper(root.right, depth + 1)) + 1;
    }
}
