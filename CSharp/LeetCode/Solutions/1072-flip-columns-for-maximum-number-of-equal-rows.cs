using LeetCode.Solutions.Shared;
using System;
using System.Text;

namespace LeetCode.Solutions;

internal class Solution1072 : IRunProgram
{ 
    public void Run()
    {
        MaxEqualRowsAfterFlips([[0, 1], [1, 0]]).Print();
    }

    public int MaxEqualRowsAfterFlips(int[][] matrix)
    {
        var freq = new Dictionary<string, int>();
        Span<char> buffer = stackalloc char[matrix[0].Length];
        Span<char> buffer_invert = stackalloc char[matrix[0].Length];
        int res = 0;

        foreach (int[] row in matrix)
        {
            for (int i = 0; i < row.Length; i++)
            {
                buffer[i] = (char)(row[i] + '0');
                buffer_invert[i] = (char)(1 - row[i] + '0');
            }
            string mask = new string(buffer);
            if (freq.ContainsKey(mask))
            {
                freq[mask]++;
            }
            else
            {
                mask = new string(buffer_invert);
                if (freq.ContainsKey(mask))
                {
                    freq[mask]++;
                }
                else
                {
                    freq.Add(mask, 1);
                }
            }
            res = Math.Max(res, freq[mask]);
        }
        // Console.WriteLine(String.Join(", ", freq.Select(x => $"[{x.Key} : {x.Value}]")));
        return res;
    }
}
