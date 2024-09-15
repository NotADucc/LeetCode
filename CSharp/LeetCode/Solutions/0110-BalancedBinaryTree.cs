using LeetCode.Shared;

namespace LeetCode.CSharp;

internal class Solution0110 : IRunProgram
{
    public void Run()
    {
        IsBalanced(new TreeNode(3, new TreeNode(9), new TreeNode(20, new TreeNode(15), new TreeNode(7)))).Print();
    }

    public bool IsBalanced(TreeNode root)
    {
        // TODO
        return false;
    }
}
