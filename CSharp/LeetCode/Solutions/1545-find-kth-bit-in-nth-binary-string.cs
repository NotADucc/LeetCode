using LeetCode.Solutions.Shared;
using System.Text;

namespace LeetCode.Solutions;

internal class Solution1545 : IRunProgram
{
    public void Run()
    {

    }

    public char FindKthBit(int n, int k)
    {
        k--;
        StringBuilder sb = new StringBuilder("0");

        while (sb.Length <= k)
        {
            Span<char> span = sb.Length >= 10_000 
                ? new char[sb.Length + 1] 
                : stackalloc char[sb.Length + 1];
            span[0] = '1';
            for (int i = 0; i < sb.Length; i++)
            {
                char reversed = sb[i] == '0' ? '1' : '0';
                span[^(i + 1)] = reversed;
            }

            sb.Append(span);
        }

        return sb[k];
    }
}
