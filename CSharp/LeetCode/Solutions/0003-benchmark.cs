using BenchmarkDotNet.Attributes;
using LeetCode.Solutions.Benchmark;

namespace LeetCode.Solutions;

public class Benchmark0003 : BenchmarkAttributes
{
    string input;

    Solution0003 proj = null;

    [GlobalSetup]
    public void Setup()
    {
        proj = new Solution0003();
        input = "abcdefghijklmnopqrstvwxyz1234567890&|#(){}^?,;.:+-!abcdefghijklmnopqrstvwxyz1234567890&|#(){}^?,;.:+-!";
    }

    [Benchmark(Baseline = true)]
    public int Set()
    {
        return LengthOfLongestSubstring(input);
    }

    [Benchmark]
    public int Mask()
    {
        return proj.LengthOfLongestSubstring(input);
    }

    public int LengthOfLongestSubstring(string s)
    {
        var set = new HashSet<char>();
        int output = 0;
        int l = 0, r = 0;

        while (r < s.Length)
        {
            if (set.Contains(s[r]))
            {
                while (s[l] != s[r])
                {
                    set.Remove(s[l]);
                    l++;
                }
                set.Remove(s[l]);
                l++;
            }
            else
            {
                set.Add(s[r]);
                output = Math.Max(output, r - l + 1);
                r++;
            }
        }

        return output;
    }
}
