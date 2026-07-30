using LeetCode.Solutions.Shared;

namespace LeetCode.Solutions;
internal class Solution0559 : IRunProgram
{
    public void Run()
    {

    }

    public int MaxDepth(Node root)
    {
        if (root is null)
            return 0;

        int d = 0;
        foreach (var c in root.children)
            d = Math.Max(d, MaxDepth(c));

        return 1 + d;
    }
}
