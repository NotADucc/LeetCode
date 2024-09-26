using BenchmarkDotNet.Attributes;
using LeetCode.Solutions.Benchmark;

namespace LeetCode.Solutions;

public class Benchmark0884 : BenchmarkAttributes
{
    string[] input;

    Solution0884 proj = null;

    [GlobalSetup]
    public void Setup()
    {
        proj = new Solution0884();
        input = ["this apple is sweet", "this apple is sour"];
    }

    [Benchmark(Baseline = true)]
    public string[] Span()
    {
        return proj.UncommonFromSentences(input[0], input[1]);
    }

    [Benchmark]
    public string[] Naive()
    {
        return UncommonFromSentences(input[0], input[1]);
    }

    public string[] UncommonFromSentences(string s1, string s2)
    {
        // key is word
        // value is freq
        var output = new Dictionary<string, int>();
        string[] s1_split = s1.Split(' ');
        string[] s2_split = s2.Split(' ');

        for (int i = 0; i < s1_split.Length; i++)
        {
            if (!output.TryAdd(s1_split[i], 1)) output[s1_split[i]]++;
        }

        for (int i = 0; i < s2_split.Length; i++)
        {
            if (!output.TryAdd(s2_split[i], 1)) output[s2_split[i]]++;
        }

        return output.Where(x => x.Value == 1).Select(x => x.Key).ToArray();
    }
}
