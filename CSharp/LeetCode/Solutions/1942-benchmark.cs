using BenchmarkDotNet.Attributes;
using LeetCode.Solutions.Benchmark;

namespace LeetCode.Solutions
{
    public class Benchmark1942 : BenchmarkAttributes
    {

        Solution1942 proj = null;
        int[][] input;
        [Params(1, 6, 15)]
        public int target_friend;

        [GlobalSetup]
        public void Setup()
        {
            proj = new Solution1942();
            input = [[33889, 98676], [80071, 89737], [44118, 52565], [52992, 84310], [78492, 88209], [21695, 67063], [84622, 95452], [98048, 98856], [98411, 99433], [55333, 56548], [65375, 88566], [55011, 62821], [48548, 48656], [87396, 94825], [55273, 81868], [75629, 91467]];
        }

        [Benchmark(Baseline = true)]
        public int Sorting()
        {
            return proj.SmallestChair(input, target_friend);
        }

        [Benchmark]
        public int NoSorting()
        {
            return SmallestChair(input, target_friend);
        }

        public int SmallestChair(int[][] times, int targetFriend)
        {
            static void RemoveGuests(PriorityQueue<(int, int), int> leaves, int other_arrival, Dictionary<int, int> seat_history, PriorityQueue<int, int> open_chairs)
            {
                while (leaves.Count > 0 && other_arrival >= leaves.Peek().Item1)
                {
                    int open_chair = seat_history[leaves.Dequeue().Item2];
                    open_chairs.Enqueue(open_chair, open_chair);
                }
            }

            // 'keys' are times
            // values are indexes
            var arrivals = new PriorityQueue<(int, int), int>();
            var leaves = new PriorityQueue<(int, int), int>();
            for (int i = 0; i < times.Length; i++)
            {
                var time = times[i];
                arrivals.Enqueue((time[0], i), time[0]);
                leaves.Enqueue((time[1], i), time[1]);
            }

            int chair = 0, target_arrival = times[targetFriend][0];
            // key is index
            // value is chair nr 
            var seat_history = new Dictionary<int, int>();
            var open_chairs = new PriorityQueue<int, int>();
            while (arrivals.Count > 0 && arrivals.Peek().Item1 != target_arrival)
            {
                (int other_arrival, int other_index) = arrivals.Dequeue();
                RemoveGuests(leaves, other_arrival, seat_history, open_chairs);
                int allocated_chair = open_chairs.Count > 0 ? open_chairs.Dequeue() : chair++;
                seat_history.Add(other_index, allocated_chair);
            }

            RemoveGuests(leaves, target_arrival, seat_history, open_chairs);

            return open_chairs.Count > 0 ? open_chairs.Dequeue() : chair;
        }
    }
}
