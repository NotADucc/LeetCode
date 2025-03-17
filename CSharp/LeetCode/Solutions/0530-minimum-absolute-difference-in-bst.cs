using LeetCode.Solutions.Shared;

namespace LeetCode.Solutions;

internal class Solution0530 : IRunProgram
{
    public void Run()
    {

    }

    public int GetMinimumDifference(TreeNode root)
    {
        int output = int.MaxValue;
        var lst = new List<int>();
        Helper(root, lst);
        for (int i = 0; i < lst.Count - 1; i++)
        {
            output = Math.Min(output, lst[i + 1] - lst[i]);
        }
        return output;
    }
    public void Helper(TreeNode root, List<int> lst)
    {
        if (root is null) return;
        Helper(root.left, lst);
        lst.Add(root.val);
        Helper(root.right, lst);
    }
}
