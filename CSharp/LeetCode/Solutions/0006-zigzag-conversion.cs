using LeetCode.Solutions.Shared;
using System.Text;

namespace LeetCode.Solutions;

internal class Solution0006 : IRunProgram
{
    public void Run()
    {
        Convert("PAYPALISHIRING", 3).Print();
        Convert("PAYPALISHIRING", 4).Print();
    }
    public string Convert(string s, int numRows)
    {
        if (numRows == 1) { return s; }
        int numRows_2 = (numRows - 1) << 1;
        var output = new StringBuilder[numRows];
        for (int i = 0; i < numRows; i++) { output[i] = new StringBuilder(); }
        for (int i = 0; i < s.Length; i++)
        {
            int rem = i % numRows_2;
            if (rem < numRows)
            {
                output[rem].Append(s[i]);
            }
            else
            {
                output[numRows_2 - rem].Append(s[i]);
            }
        }

        return string.Concat(output.Select(x => x.ToString()));
    }
}
