using LeetCode.Shared;

namespace LeetCode.CSharp;

internal class Solution0216 : IRunProgram
{
    public void Run()
    {
        CombinationSum3(3, 7).PrintNested();
        CombinationSum3(3, 9).PrintNested();
    }
    public IList<IList<int>> CombinationSum3(int k, int n)
    {
        if (k >= n)
        {
            return [];
        }

        var output = new List<IList<int>>();

        Helper(output, [], k, n, 0, 1);

        return output;
    }

    private void Helper(List<IList<int>> output, List<int> curr, int k, int n, int sum, int index)
    {
        if (sum == n)
        {
            if (curr.Count == k)
            {
                output.Add(new List<int>(curr));
            }
        }
        else if (sum < n)
        {
            for (int i = index; i < 10; i++)
            {
                curr.Add(i);
                Helper(output, curr, k, n, sum + i, i + 1);
                curr.Remove(i);
            }
        }
    }
}
