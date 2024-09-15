using LeetCode.Shared;

namespace LeetCode.CSharp;

internal class Solution1046: IRunProgram
{
    public void Run()
    {
        LastStoneWeight([2, 7, 4, 1, 8, 1]).Print();
    }

    public int LastStoneWeight(int[] stones)
    {
        PriorityQueue<int, int> queue = new PriorityQueue<int, int>(stones.Select(x => (x, x)), Comparer<int>.Create((a, b) => b - a));

        while (queue.Count > 1)
        {
            int stone1 = queue.Dequeue();
            int stone2 = queue.Dequeue();

            int delta = stone1 - stone2;
            if (delta != 0) { queue.Enqueue(delta, delta); }
        }

        return queue.Count > 0 ? queue.Peek() : 0;
    }
}
