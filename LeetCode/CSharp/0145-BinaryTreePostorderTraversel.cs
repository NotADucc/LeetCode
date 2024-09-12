using LeetCode.Shared;

namespace LeetCode.CSharp;

internal class Solution0145 : IRunProgram
{
    public void Run()
    {
        PostorderTraversal(new TreeNode(1, new TreeNode(2), new TreeNode(3))).Print();
    }
    public IList<int> PostorderTraversal(TreeNode root)
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

        Helper(output, root.left);
        Helper(output, root.right);
        output.Add(root.val);
    }
}
