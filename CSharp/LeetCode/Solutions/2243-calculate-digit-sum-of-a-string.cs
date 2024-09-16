using LeetCode.Shared;
using System.Text;

namespace LeetCode.CSharp;

internal class Solution2243 : IRunProgram
{
    public void Run()
    {
        DigitSum("11111222223", 3).Print();
    }

    public string DigitSum(string s, int k)
    {
        while (s.Length > k)
        {
            int k_count = s.Length / k;
            k_count = s.Length % k == 0 ? k_count : k_count + 1;

            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < k_count - 1; i++)
            {
                Helper(s.AsSpan().Slice(i * k, k), sb);
            }

            Helper(s.AsSpan().Slice((k_count - 1) * k), sb);

            s = sb.ToString();
        }

        return s;
    }

    private void Helper(ReadOnlySpan<char> num, StringBuilder sb)
    {
        int temp = 0;
        for (int i = 0; i < num.Length; i++)
        {
            temp += num[i] - '0';
        }
        sb.Append(temp);
    }
}
