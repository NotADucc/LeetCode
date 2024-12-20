using LeetCode.Solutions.Shared;

namespace LeetCode.Solutions;

internal class Solution2415 : IRunProgram
{
    public void Run()
    {

    }

    public TreeNode ReverseOddLevels(TreeNode root)
    {
        var dct = new Dictionary<int, List<TreeNode>>();
        Traverse(root, dct, 0);

        foreach (var kvp in dct)
        {
            var lst = kvp.Value;
            int l = 0, r = lst.Count - 1;
            while (l < r)
            {
                lst[l].val ^= lst[r].val;
                lst[r].val ^= lst[l].val;
                lst[l].val ^= lst[r].val;

                l++; r--;
            }
        }

        return root;
    }

    private void Traverse(TreeNode root, Dictionary<int, List<TreeNode>> dct, int depth)
    {
        if (root is null)
            return;

        if ((depth & 1) == 1)
        {
            dct.TryAdd(depth, new List<TreeNode>());
            dct[depth].Add(root);
        }

        Traverse(root.left, dct, depth + 1);
        Traverse(root.right, dct, depth + 1);
    }

    // Optimal
    public TreeNode ReverseOddLevelsDFS(TreeNode root)
    {
        DFS(root.left, root.right, 1);
        return root;
    }

    private void DFS(TreeNode l, TreeNode r, int depth)
    {
        if (l is null || r is null)
            return;

        if ((depth & 1) == 1)
        {
            l.val ^= r.val;
            r.val ^= l.val;
            l.val ^= r.val;
        }

        DFS(l.left, r.right, depth + 1);
        DFS(l.right, r.left, depth + 1);
    }
}
