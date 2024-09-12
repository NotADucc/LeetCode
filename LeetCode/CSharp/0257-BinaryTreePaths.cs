using LeetCode.Shared;
using System.Text;

namespace LeetCode.CSharp;

internal class Solution0257 : IRunProgram
{
    public void Run()
    {
        BinaryTreePaths(new TreeNode(1)).Print();
        BinaryTreePaths(new TreeNode(1, new TreeNode(2), new TreeNode(3))).Print();
    }

    public IList<string> BinaryTreePaths(TreeNode root)
    {
        List<string> paths = new List<string>();

        Helper(paths, new StringBuilder(), root);

        return paths;
    }
    private void Helper(List<string> output, StringBuilder sb, TreeNode? root)
    {
        if (root is null) { return; }

        ReadOnlySpan<char> val = sb.Length == 0 ? root.val.ToString() : $"->{root.val}";
        sb.Append(val);

        if (root.left is null && root.right is null)
        {
            output.Add(sb.ToString());
        }
        else
        {
            Helper(output, sb, root.left);
            Helper(output, sb, root.right);
        }

        sb.Remove(sb.Length - val.Length, val.Length);
    }
}
