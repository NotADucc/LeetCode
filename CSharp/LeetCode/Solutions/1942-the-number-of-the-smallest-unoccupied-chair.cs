using LeetCode.Solutions.Shared;

namespace LeetCode.Solutions;

internal class Solution1942 : IRunProgram
{
    public void Run()
    {
        SmallestChair([[33889, 98676], [80071, 89737], [44118, 52565], [52992, 84310], [78492, 88209], [21695, 67063], [84622, 95452], [98048, 98856], [98411, 99433], [55333, 56548], [65375, 88566], [55011, 62821], [48548, 48656], [87396, 94825], [55273, 81868], [75629, 91467]], 6).Print();
    }

    public int SmallestChair(int[][] times, int targetFriend)
    {
        int target_arrival = times[targetFriend][0];
        Array.Sort(times, (a, b) => { return a[0] - b[0]; });
        // key is index
        // value is chair nr 
        var seat_history = new Dictionary<int, int>();
        var leaves = new PriorityQueue<(int, int), int>();
        var open_chairs = new PriorityQueue<int, int>();
        int chair = 0;
        for (int i = 0; i < times.Length; i++)
        {
            int other_arrival = times[i][0], other_leave = times[i][1];

            while (leaves.Count > 0 && other_arrival >= leaves.Peek().Item1)
            {
                int open_chair = seat_history[leaves.Dequeue().Item2];
                open_chairs.Enqueue(open_chair, open_chair);
            }

            if (target_arrival == other_arrival) 
            {
                break;
            }

            leaves.Enqueue((other_leave, i), other_leave);
            int allocated_chair = open_chairs.Count > 0 ? open_chairs.Dequeue() : chair++;
            seat_history.Add(i, allocated_chair);
        }

        return open_chairs.Count > 0 ? open_chairs.Dequeue() : chair;
    }
}
