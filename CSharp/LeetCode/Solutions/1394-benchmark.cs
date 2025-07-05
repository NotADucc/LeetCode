using BenchmarkDotNet.Attributes;
using LeetCode.Solutions.Benchmark;

namespace LeetCode.Solutions;
public class Benchmark1394 : BenchmarkAttributes
{
    int[] input;

    Solution1394 proj;

    [GlobalSetup]
    public void Setup()
    {
        proj = new();
        input = [1, 2, 2, 10, 30, 11, 11, 11, 11, 11, 11, 11, 11, 11, 11, 11, 2, 3, 4, 5, 6, 7, 8, 9, 10, 3, 4, 5, 6, 10];
    }

    [Benchmark(Baseline = true)]
    public int KvpPrio()
    {
        return FindLucky(input);
    }

    [Benchmark]
    public int Dict()
    {
        return proj.FindLucky(input);
    }

    public int FindLucky(int[] arr)
    {
        var freq = new Dictionary<int, Kvp<int, int>>();
        var q = new PriorityQueue<Kvp<int, int>, int>();

        foreach (int num in arr)
        {
            if (freq.TryGetValue(num, out var kvp))
            {
                kvp.Value++;
            }
            else
            {
                kvp = new Kvp<int, int>(num, 1);
                freq.Add(num, kvp);
                q.Enqueue(kvp, -num);
            }
        }

        while (q.Count > 0)
        {
            var deq = q.Dequeue();
            if (deq.Key == deq.Value)
                return deq.Key;
        }

        return -1;
    }

    public class Kvp<K, V>
    {
        public K Key { get; set; }
        public V Value { get; set; }

        public Kvp() { }

        public Kvp(K key, V val)
        {
            this.Key = key;
            this.Value = val;
        }
    }
}
