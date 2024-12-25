using LeetCode.Solutions.Shared;

namespace LeetCode.Solutions;

internal class Solution0515 : IRunProgram
{
    public void Run()
    {

    }
    public IList<int> LargestValues(TreeNode root)
    {
        List<int> res = new List<int>();
        Rec(res, root);
        return res;
    }
    private void Rec(List<int> res, TreeNode root, int depth = 0)
    {
        if (root is null)
            return;

        if (depth >= res.Count)
            res.Add(root.val);
        else
            res[depth] = Math.Max(res[depth], root.val);

        Rec(res, root.left, depth + 1);
        Rec(res, root.right, depth + 1);
    }
}
