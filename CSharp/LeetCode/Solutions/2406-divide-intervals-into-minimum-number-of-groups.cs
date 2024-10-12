using LeetCode.Solutions.Shared;

namespace LeetCode.Solutions;

internal class Solution2406 : IRunProgram
{
    public void Run()
    {

    }

    public int MinGroups(int[][] intervals)
    {
        Array.Sort(intervals, (a, b) => a[0] - b[0]);

        // value and prio is right interval (ending of an interval)
        var queue = new PriorityQueue<int, int>();

        foreach (var interval in intervals)
        {
            if (queue.Count <= 0)
            {
                queue.Enqueue(interval[1], interval[1]);
            }
            else
            {
                if (queue.Peek() < interval[0])
                {
                    queue.Dequeue();
                }
                queue.Enqueue(interval[1], interval[1]);
            }
        }

        return queue.Count;
    }
}
