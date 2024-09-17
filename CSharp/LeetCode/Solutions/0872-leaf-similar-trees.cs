using LeetCode.Solutions.Shared;

namespace LeetCode.Solutions;

internal class Solution0872 : IRunProgram
{
    public void Run()
    {

    }

    public bool LeafSimilar(TreeNode root1, TreeNode root2)
    {
        return GetLeafs(root1).SequenceEqual(GetLeafs(root2));
    }
    public IEnumerable<int> GetLeafs(TreeNode root)
    {
        if (root is not null)
        {
            if (root.left is null && root.right is null) yield return root.val;

            if (root.left is not null)
            {
                foreach (var leaf in GetLeafs(root.left))
                {
                    yield return leaf;
                }
            }

            if (root.right is not null)
            {
                foreach (var leaf in GetLeafs(root.right))
                {
                    yield return leaf;
                }
            }
        }
    }
}
