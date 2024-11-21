using LeetCode.Solutions.Shared;
using System.ComponentModel;

namespace LeetCode.Solutions;

internal class Solution2257 : IRunProgram
{
    public void Run()
    {
        
    }

    public int CountUnguarded(int m, int n, int[][] guards, int[][] walls)
    {
        // key is r * n + c
        // value is bitmask
        // 1 is r, 2 is c, 3 is both
        var visited = new Dictionary<int, int>();
        int res = m * n - walls.Length;

        for (int i = 0; i < walls.Length; i++)
            visited.Add(walls[i][0] * n + walls[i][1], 3);

        foreach (int[] guard in guards)
        {
            int r = guard[0], c = guard[1];
            // row -
            for (int j = r; j >= 0; j--)
            {
                int ind = j * n + c;
                if (visited.TryAdd(ind, 1))
                {
                    res--;
                }
                else
                {
                    if ((visited[ind] & 1) == 1) break;
                    visited[ind] |= 1;
                }
            }
            // row +
            for (int j = r + 1; j < m; j++)
            {
                int ind = j * n + c;
                if (visited.TryAdd(ind, 1))
                {
                    res--;
                }
                else
                {
                    if ((visited[ind] & 1) == 1) break;
                    visited[ind] |= 1;
                }
            }
            // col -
            for (int j = c; j >= 0; j--)
            {
                int ind = r * n + j;
                if (visited.TryAdd(ind, 2))
                {
                    res--;
                }
                else
                {
                    if ((visited[ind] & 2) == 2) break;
                    visited[ind] |= 2;
                }
            }
            // col +
            for (int j = c + 1; j < n; j++)
            {
                int ind = r * n + j;
                if (visited.TryAdd(ind, 2))
                {
                    res--;
                }
                else
                {
                    if ((visited[ind] & 2) == 2) break;
                    visited[ind] |= 2;
                }
            }
        }
        // Console.WriteLine(string.Join(", ", visited.Select(x => $"{x.Key}: {x.Value}")));
        return res;
    }
}
