using LeetCode.Shared;

namespace LeetCode.CSharp;

public class Solution0077 : IRunProgram
{
    public void Run()
    {
        Combine(2, 4).PrintNested();
        Combine(1, 1).PrintNested();
    }

    public IList<IList<int>> Combine(int n, int k)
    {
        var output = new List<IList<int>>();
        Helper(output, [], n, k, 1);
        return output;
    }

    private void Helper(List<IList<int>> output, List<int> current, int n, int k, int index)
    {
        if (current.Count == k)
        {
            output.Add(new List<int>(current));
        }
        else
        {
            for (int i = index; i <= n; i++)
            {
                current.Add(i);
                Helper(output, current, n, k, i + 1);
                current.Remove(i);
            }
        }
    }
}
