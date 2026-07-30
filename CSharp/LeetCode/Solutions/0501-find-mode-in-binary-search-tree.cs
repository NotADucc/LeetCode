using LeetCode.Solutions.Shared;

namespace LeetCode.Solutions;
internal class Solution0501 : IRunProgram
{
    public void Run()
    {

    }

    public int[] FindMode(TreeNode root)
    {
        Dictionary<int, int> freq = [];
        r(root, freq);
        int max = freq.Max(x => x.Value);

        return freq
            .Where(x => x.Value == max)
            .Select(x => x.Key)
            .ToArray();
    }

    public void r(TreeNode root, Dictionary<int, int> freq)
    {
        if (root is null)
            return;

        freq.TryAdd(root.val, 0);
        freq[root.val]++;

        r(root.left, freq);
        r(root.right, freq);
    }
}
