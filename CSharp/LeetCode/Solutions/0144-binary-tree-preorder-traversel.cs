using LeetCode.Shared;

namespace LeetCode.CSharp;

internal class Solution0144 : IRunProgram
{
    public void Run()
    {
        PreorderTraversal(new TreeNode(1, new TreeNode(2), new TreeNode(3))).Print();
    }
    public IList<int> PreorderTraversal(TreeNode root)
    {
        var output = new List<int>();
        Helper(output, root);
        return output;
    }

    private void Helper(List<int> output, TreeNode root)
    {
        if (root is null)
        {
            return;
        }

        output.Add(root.val);
        Helper(output, root.left);
        Helper(output, root.right);
    }
}
