using BenchmarkDotNet.Attributes;
using LeetCode.Solutions.Benchmark;
using System.Text;

namespace LeetCode.Solutions;

public class Benchmark0093 : BenchmarkAttributes
{
    [Params("0000", "255255111")]
    public string input;
    private Solution0093 sol;
    [GlobalSetup]
    public void Setup() 
    {
        sol = new Solution0093();
    }

    [Benchmark(Baseline = true)]
    public IList<string> Baseline() 
    {
        return sol.RestoreIpAddresses(input);
    }

    [Benchmark]
    public IList<string> MoreBranches()
    {
        return RestoreIpAddresses(input);
    }

    public IList<string> RestoreIpAddresses(string s)
    {
        if (s.Length < 4) return [];

        var output = new List<string>();
        Backtrack(output, new StringBuilder(), s, null, 0, 0);
        return output;
    }
    private void Backtrack(List<string> output, StringBuilder sb, ReadOnlySpan<char> input, int? octet, int octet_count, int index)
    {
        if (octet_count > 4) return;

        if (sb.Length - 3 == input.Length)
        {
            output.Add(sb.ToString());
        }
        else
        {
            int max_index = Math.Min(index + 3, input.Length);
            for (int i = index; i < max_index; i++)
            {
                if (octet.HasValue)
                {
                    if (octet.Value == 0 || octet > 25 || octet == 25 && input[i] > '5') break;

                    octet *= 10;
                    octet += input[i] - '0';
                }
                else
                {
                    octet = input[i] - '0';
                }
                string octet_string = sb.Length == 0 ? octet.Value.ToString() : $".{octet.Value}";
                sb.Append(octet_string);
                Backtrack(output, sb, input, null, octet_count + 1, i + 1);
                sb.Remove(sb.Length - octet_string.Length, octet_string.Length);
            }
        }
    }
}
