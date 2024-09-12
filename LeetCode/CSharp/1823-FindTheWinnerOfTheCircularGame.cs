using LeetCode.Shared;

namespace LeetCode.CSharp;

internal class Solution1823 : IRunProgram
{
    public void Run()
    {
        FindTheWinner(5, 2).Print();
    }

    public int FindTheWinner(int n, int k)
    {
        List<int> list = new List<int>();

        for (int i = 1; i <= n; i++)
        {
            list.Add(i);
        }

        int removeAt = k - 1;
        while (list.Count > 1)
        {
            list.RemoveAt(removeAt);
            removeAt = (removeAt + k - 1);
            removeAt %= list.Count;
        }

        return list[0];
    }
}
