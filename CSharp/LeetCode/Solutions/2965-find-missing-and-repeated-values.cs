using LeetCode.Solutions.Shared;

namespace LeetCode.Solutions;

internal class Solution2965 : IRunProgram
{
    public void Run()
    {

    }

    public int[] FindMissingAndRepeatedValues(int[][] grid)
    {
        HashSet<int> dupes = new HashSet<int>();
        int n = grid.Length * grid[0].Length;
        int dupe = -1, triangle = (n * (n + 1)) >> 1;

        for (int i = 0; i < grid.Length; i++)
        {
            for (int j = 0; j < grid[i].Length; j++)
            {
                int val = grid[i][j];
                triangle -= val;
                if (!dupes.Add(val))
                {
                    dupe = val;
                }
            }
        }

        return [dupe, triangle + dupe];
    }
}
