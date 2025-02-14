using LeetCode.Solutions.Shared;

namespace LeetCode.Solutions;

internal class Solution3160 : IRunProgram
{
    public void Run()
    {

    }

    public int[] QueryResults(int limit, int[][] queries)
    {
        int total_colors = 0;
        var latest_color = new Dictionary<int, int>();
        var colors = new Dictionary<int, int>();
        var res = new int[queries.Length];

        for (int i = 0; i < queries.Length; i++)
        {
            int q_bal = queries[i][0], q_color = queries[i][1];
            colors.TryGetValue(q_color, out int tot);
            if (tot == 0)
            {
                total_colors++;
                colors.TryAdd(q_color, 0);
            }

            colors[q_color]++;

            latest_color.TryGetValue(q_bal, out int latest_bal_color);
            if (latest_bal_color != 0)
            {
                colors[latest_bal_color]--;
                if (colors[latest_bal_color] == 0)
                    total_colors--;
            }

            latest_color[q_bal] = q_color;

            res[i] = total_colors;
        }

        return res;
    }
}
