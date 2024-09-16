using LeetCode.Solutions.Shared;

namespace LeetCode.Solutions;

internal class Solution0215 : IRunProgram
{
    public void Run()
    {
        FindKthLargest([3, 2, 1, 5, 6, 4], 2).Print();
    }
    public int FindKthLargest(int[] nums, int k)
    {
        PriorityQueue<int, int> q = new PriorityQueue<int, int>();

        foreach (var num in nums)
        {
            q.Enqueue(num, num);

            if (q.Count > k)
            {
                q.Dequeue();
            }
        }

        return q.Peek();
    }
}
