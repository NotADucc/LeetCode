using LeetCode.Solutions.Shared;
using LeetCode.Solutions.Shared;

namespace LeetCode.Solutions;

internal class Solution0590 : IRunProgram
{
    public void Run()
    {
        
    }
    public IList<int> Postorder(Node root)
    {
        var output = new List<int>();

        Helper(root, output);

        return output;
    }

    private void Helper(Node root, List<int> output)
    {
        if (root is null)
        {
            return;
        }

        foreach (var child in root.children)
        {
            Helper(child, output);
        }

        output.Add(root.val);
    }
}
