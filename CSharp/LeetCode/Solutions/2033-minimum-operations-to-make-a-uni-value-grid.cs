using LeetCode.Solutions.Shared;
using System.Text;

namespace LeetCode.Solutions;

internal class Solution2033 : IRunProgram
{
    public void Run()
    {

    }
    public int MinOperations(int[][] grid, int x) 
    {
        int[] flat = grid
            .SelectMany(x => x)
            .OrderBy(x => x)
            .ToArray();
        int n = flat.Length, res = 0, middle_val = flat[n >> 1];

        for (int i = 0; i < n; i++)
        {
            int delta = Math.Abs(flat[i] - middle_val);
            if (delta % x != 0) return -1;
            res += delta / x;
        }

        return res;
    }
}
