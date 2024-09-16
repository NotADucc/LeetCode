using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Configs;

namespace LeetCode.Solutions.Benchmark;

[MemoryDiagnoser]
[GroupBenchmarksBy(BenchmarkLogicalGroupRule.ByCategory)]
[CategoriesColumn]
[Config(typeof(Config))]
public class BenchmarkAttributes { }