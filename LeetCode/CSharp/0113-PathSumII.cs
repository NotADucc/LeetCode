using LeetCode.Shared;

namespace LeetCode.CSharp;

internal class Solution0113 : IRunProgram
{
    public void Run()
    {
        PathSum(new TreeNode(5, new TreeNode(4, new TreeNode(11, new TreeNode(7), new TreeNode(2))), new TreeNode(8, new TreeNode(13), new TreeNode(4, null, new TreeNode(1)))), 22).Print();
        PathSum(new TreeNode(1, new TreeNode(2), new TreeNode(3)), 5).Print();
    }

    public IList<IList<int>> PathSum(TreeNode root, int targetSum)
    {
        if (root is null) { return []; }

        var output = new List<IList<int>>();

        if (root.left is null && root.right is null && targetSum == root.val)
        {
            return [[root.val]];
        }

        Helper(output, [root.val], root.left, targetSum, root.val);
        Helper(output, [root.val], root.right, targetSum, root.val);

        return output;
    }

    private void Helper(List<IList<int>> output, List<int> current, TreeNode root, int target, int currentVal)
    {
        if (root is null) { return; }

        if (currentVal + root.val == target && root.left is null && root.right is null)
        {
            output.Add([.. current, root.val]);
        }
        else
        {
            current.Add(root.val);
            Helper(output, current, root.left, target, currentVal + root.val);
            Helper(output, current, root.right, target, currentVal + root.val);
            current.RemoveAt(current.LastIndexOf(root.val));
        }
    }
}
