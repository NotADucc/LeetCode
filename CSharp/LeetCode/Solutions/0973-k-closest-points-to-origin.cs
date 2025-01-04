using LeetCode.Solutions.Shared;

namespace LeetCode.Solutions;

internal class Solution0973 : IRunProgram
{
    public void Run()
    {

    }

    public int[][] KClosest(int[][] points, int k)
    {
        var q = new PriorityQueue<int[], int>();

        for (int i = 0; i < points.Length; i++)
        {
            int x = points[i][0] * points[i][0];
            int y = points[i][1] * points[i][1];
            q.Enqueue(points[i], x + y);
        }

        int[][] res = new int[k][];
        for (int i = 0; i < k; i++) res[i] = q.Dequeue();

        return res;
    }
}
