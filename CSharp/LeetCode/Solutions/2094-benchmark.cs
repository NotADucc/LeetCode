using BenchmarkDotNet.Attributes;
using LeetCode.Solutions.Benchmark;

namespace LeetCode.Solutions;

public class Benchmark2094 : BenchmarkAttributes
{
    int[] input;

    Solution2094 proj = null;

    [GlobalSetup]
    public void Setup()
    {
        proj = new();
        input = [0, 0, 0, 1, 1, 1, 2, 2, 2, 3, 3, 3, 4, 4, 4, 5, 5, 5, 6, 6, 6, 7, 7, 7, 8, 8, 8, 9, 9, 9, 0, 0, 0];
    }

    [Benchmark(Baseline = true)]
    public int[] Stackalloc()
    {
        return FindEvenNumbers(input);
    }

    [Benchmark]
    public int[] List()
    {
        return proj.FindEvenNumbers(input);
    }

    public int[] FindEvenNumbers(int[] digits)
    {
        Span<int> res = stackalloc int[450];
        int res_idx = 0;
        Span<int> freq = stackalloc int[10];

        foreach (int digit in digits)
            freq[digit]++;

        for (int i = 100; i < 1000; i += 2)
        {
            Span<int> compare = stackalloc int[10];
            int dig1 = i / 100, dig2 = (i / 10) % 10, dig3 = i % 10;
            compare[dig1]++;
            compare[dig2]++;
            compare[dig3]++;
            if (compare[dig1] <= freq[dig1]
                && compare[dig2] <= freq[dig2]
                && compare[dig3] <= freq[dig3])
                res[res_idx++] = i;
        }

        return res.Slice(0, res_idx).ToArray();
    }
}
