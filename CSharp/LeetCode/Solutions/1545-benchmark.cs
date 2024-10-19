using BenchmarkDotNet.Attributes;
using LeetCode.Solutions.Benchmark;
using System.Text;

namespace LeetCode.Solutions
{
    public class Benchmark1545 : BenchmarkAttributes
    {
        [Params(100)]
        public int k;

        Solution1545 proj = null;

        [GlobalSetup]
        public void Setup()
        {
            proj = new Solution1545();
        }

        [Benchmark(Baseline = true)]
        public int Inline()
        {
            return proj.FindKthBit(0, k);
        }

        [Benchmark]
        public int Method()
        {
            return FindKthBit(0, k);
        }

        public char FindKthBit(int _, int k)
        {
            k--;
            StringBuilder sb = new StringBuilder("0");

            while (sb.Length <= k)
            {
                string new_str = ApplyChanges(sb);
                sb.Append("1");
                sb.Append(new_str);
            }

            return sb[k];
        }
        private string ApplyChanges(StringBuilder sb)
        {
            Span<char> span = stackalloc char[sb.Length];
            for (int i = 0; i < sb.Length; i++)
            {
                char reversed = sb[i] == '0' ? '1' : '0';
                span[^(i + 1)] = reversed;
            }
            return span.ToString();
        }
    }
}
