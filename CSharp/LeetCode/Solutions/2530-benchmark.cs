using BenchmarkDotNet.Attributes;
using LeetCode.Solutions.Benchmark;

namespace LeetCode.Solutions
{
    public class Benchmark2530 : BenchmarkAttributes
    {
        int[] input;
        [Params(5, 10, 30)]
        public int k;
        Solution2530 proj = null;

        [GlobalSetup]
        public void Setup()
        {
            proj = new Solution2530();
            input = [10, 10, 10, 10, 10, 30, 60, 30, 30, 40];
        }

        [Benchmark(Baseline = true)]
        public long MathCeiling()
        {
            return proj.MaxKelements(input, k);
        }

        [Benchmark]
        public long Branch()
        {
            return MaxKelements(input, k);
        }

        public long MaxKelements(int[] nums, int k)
        {
            PriorityQueue<int, int> queue = new PriorityQueue<int, int>(nums.Select(x => (x, x)), Comparer<int>.Create((a, b) => b - a));
            long output = 0L;

            for (int i = 0; i < k; i++)
            {
                int value = queue.Dequeue();
                output += value;
                int rest = value % 3;
                value /= 3;
                value = rest > 0 ? value + 1 : value;
                queue.Enqueue(value, value);
            }

            return output;
        }
    }
}
