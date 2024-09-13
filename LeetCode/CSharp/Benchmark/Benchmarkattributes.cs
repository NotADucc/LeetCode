using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Configs;

namespace LeetCode.CSharp.Benchmark;

[MemoryDiagnoser]
[GroupBenchmarksBy(BenchmarkLogicalGroupRule.ByCategory)]
[CategoriesColumn]
[Config(typeof(Config))]
public class BenchmarkAttributes { }