using LeetCode.Solutions.Shared;

namespace LeetCode.Solutions;

internal class Solution2257 : IRunProgram
{
    public void Run()
    {
        
    }

    public int CountUnguarded(int m, int n, int[][] guards, int[][] walls)
    {
        // key is r + c
        // value is bitmask
        // 1 is r, 2 is c, 3 is both
        var visited = new Dictionary<(int, int), int>();
        var set = new HashSet<(int, int)>();
        int res = m * n - walls.Length;

        for (int i = 0; i < walls.Length; i++) set.Add((walls[i][0], walls[i][1]));

        foreach (int[] guard in guards)
        {
            int r = guard[0], c = guard[1];
            // row -
            for (int j = r; j >= 0; j--)
            {
                if (set.Contains((j, c))) break;
                if (visited.TryAdd((j, c), 1))
                {
                    res--;
                }
                else
                {
                    if ((visited[(j, c)] & 1) == 1) break;
                    visited[(j, c)] |= 1;
                }
            }
            // row +
            for (int j = r + 1; j < m; j++)
            {
                if (set.Contains((j, c))) break;
                if (visited.TryAdd((j, c), 1))
                {
                    res--;
                }
                else
                {
                    if ((visited[(j, c)] & 1) == 1) break;
                    visited[(j, c)] |= 1;
                }
            }
            // col -
            for (int j = c; j >= 0; j--)
            {
                if (set.Contains((r, j))) break;
                if (visited.TryAdd((r, j), 2))
                {
                    res--;
                }
                else
                {
                    if ((visited[(r, j)] & 2) == 2) break;
                    visited[(r, j)] |= 2;
                }
            }
            // col +
            for (int j = c + 1; j < n; j++)
            {
                if (set.Contains((r, j))) break;
                if (visited.TryAdd((r, j), 2))
                {
                    res--;
                }
                else
                {
                    if ((visited[(r, j)] & 2) == 2) break;
                    visited[(r, j)] |= 2;
                }
            }
        }
        // Console.WriteLine(string.Join(", ", visited.Select(x => $"{x.Key}: {x.Value}")));
        return res;
    }
}
