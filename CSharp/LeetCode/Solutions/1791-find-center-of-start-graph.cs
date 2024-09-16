using LeetCode.Shared;

namespace LeetCode.CSharp;

internal class Solution1791 : IRunProgram
{
    public void Run()
    {
        FindCenter([[1, 2], [2, 3], [4, 2]]).Print();
    }

    public int FindCenter(int[][] edges)
    {
        return edges[0][0] == edges[1][0] || edges[0][0] == edges[1][1] ? edges[0][0] : edges[0][1];
    }
}
