using LeetCode.Solutions.Shared;

namespace LeetCode.Solutions;

internal class Solution0386 : IRunProgram
{
    public void Run()
    {

    }

    public IList<int> LexicalOrder(int n)
    {
        IList<int> output = new List<int>(n);
        DFS(output, 1, n);
        return output;
    }
    private void DFS(IList<int> output, int current, int n)
    {
        if (current <= n)
        {
            output.Add(current);
            DFS(output, current * 10, n);
            for (int i = 1; i < 10; i++)
            {
                int temp = current + i;
                if (temp > n || output.Count >= n) break;
                output.Add(temp);
                DFS(output, temp * 10, n);
            }
        }
    }
}
