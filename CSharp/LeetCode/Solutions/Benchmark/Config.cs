using BenchmarkDotNet.Columns;
using BenchmarkDotNet.Configs;

namespace LeetCode.CSharp.Benchmark;

public sealed class Config : ManualConfig
{
    public Config()
    {
        SummaryStyle = BenchmarkDotNet.Reports.SummaryStyle.Default.WithRatioStyle(RatioStyle.Trend);
    }
}
