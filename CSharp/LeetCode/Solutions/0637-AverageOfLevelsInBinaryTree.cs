using LeetCode.Shared;

namespace LeetCode.CSharp;

internal class Solution0637 : IRunProgram
{
    public void Run()
    {
        
    }

    public IList<double> AverageOfLevels(TreeNode root)
    {
        List<long[]> output = new List<long[]>();
        Helper(root, output, 0);
        return output.Select(i => (double)i[0] / i[1]).ToList();
    }

    private void Helper(TreeNode root, List<long[]> lst, int index) 
    {
        if (root is null) return;
        if (index >= lst.Count) lst.Add(new long[2]);

        lst[index][0] += root.val;
        lst[index][1]++;
        Helper(root.left, lst, index + 1);
        Helper(root.right, lst, index + 1);
    }
}
