using LeetCode.Solutions.Shared;
using System.Text;

namespace LeetCode.Solutions;

internal class Solution1072 { 
    public void Run()
    {
        
    }

    public int MaxEqualRowsAfterFlips(int[][] matrix)
    {
        var freq = new Dictionary<string, int>();
        StringBuilder sb = new StringBuilder();
        int res = 0;

        foreach (int[] row in matrix)
        {
            int sum = 0; sb.Length = 0;
            for (int i = 0; i < row.Length; i++)
            {
                sb.Append(row[i]);
                sum += row[i];
            }
            if (sum == 0 || sum == row.Length)
            {
                res++;
            }
            else
            {
                string mask = sb.ToString();
                string invert_mask = Invert(mask);
                if (freq.ContainsKey(mask))
                {
                    freq[mask]++;
                }
                else if (freq.ContainsKey(invert_mask))
                {
                    freq[invert_mask]++;
                }
                else
                {
                    freq.Add(mask, 1);
                }
            }
        }

        foreach (var val in freq.Values)
            res = Math.Max(res, val);

        return res;
    }
    public string Invert(string input)
    {
        StringBuilder sb = new StringBuilder();
        foreach (char ch in input)
            sb.Append(ch.Equals('1') ? '0' : '1');

        return sb.ToString();
    }
}
