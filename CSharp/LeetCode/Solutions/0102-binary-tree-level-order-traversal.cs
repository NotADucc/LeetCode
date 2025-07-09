using LeetCode.Solutions.Shared;

namespace LeetCode.Solutions;
internal class Solution00102 : IRunProgram
{
    public void Run()
    {

    }

    public IList<IList<int>> LevelOrder(TreeNode root)
    {
        var res = new List<IList<int>>();
        Helper(res, root, 0);
        return res;
    }

    private void Helper(List<IList<int>> res, TreeNode root, int depth)
    {
        if (root is null) return;

        if (res.Count <= depth)
            res.Add([]);

        res[depth].Add(root.val);
        Helper(res, root.left, depth + 1);
        Helper(res, root.right, depth + 1);
    }
}
