using LeetCode.Shared;

namespace LeetCode.CSharp;

internal class Solution0094 : IRunProgram
{
    public void Run()
    {
        InorderTraversal(new TreeNode(1, null, new TreeNode(2, new TreeNode(3)))).Print();
    }
    public IList<int> InorderTraversal(TreeNode root)
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
        output.Add(root.val);
        Helper(output, root.right);
    }
}
