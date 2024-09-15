using BenchmarkDotNet.Running;
using LeetCode.CSharp;
using LeetCode.Shared;

namespace LeetCode;

public class Program
{
    public static void Main()
    {
        //BenchmarkRunner.Run<Benchmark0093>();
        Runner.RunLeetCodeSolution<Solution0334>();
    }
}
