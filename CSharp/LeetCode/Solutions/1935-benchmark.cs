using BenchmarkDotNet.Attributes;
using LeetCode.Solutions.Benchmark;

namespace LeetCode.Solutions;

public class Benchmark1935 : BenchmarkAttributes
{
    string input;
    string exclusion;

    Solution1935 proj = null;

    [GlobalSetup]
    public void Setup()
    {
        proj = new();
        input = "rxctd iujnd z ej wd sg vjr whzr uwrem gs lgpz nzdyi k zasrizg kkp bgvl yegx pc nfet lqa dbkdcg";
        exclusion = "abcdefghijklmnopqrstuvwxyz";
    }

    [Benchmark(Baseline = true)]
    public int Split()
    {
        return Split(input, exclusion);
    }

    [Benchmark]
    public int IndexOf()
    {
        return proj.CanBeTypedWords(input, exclusion);
    }

    public int Split(string text, string brokenLetters)
    {
        int broken_count = 0;
        Span<bool> is_broken = stackalloc bool[26];

        foreach (char ch in brokenLetters)
            is_broken[ch - 'a'] = true;

        var split = text
            .Split(' ')
            .ToArray();

        foreach (string word in split)
        {
            foreach (char ch in word)
            {
                if (is_broken[ch - 'a'])
                {
                    broken_count++;
                    break;
                }
            }
        }

        return split.Length - broken_count;
    }
}
