using LeetCode.Solutions.Shared;

namespace LeetCode.Solutions;

internal class Solution3022 : IRunProgram
{
    public void Run()
    {

    }

    public int MinOperations(int[] nums, int k)
    {
        var q = new PriorityQueue<long, long>();
        int res = 0;
        foreach (int num in nums)
            q.Enqueue(num, num);

        while (q.Count > 1 && q.Peek() < k)
        {
            long v1 = q.Dequeue();
            long v2 = q.Dequeue();
            long v3 = Math.Min(v1, v2) * 2 + Math.Max(v1, v2);
            q.Enqueue(v3, v3);
            res++;
        }

        return res;
    }
}
