using LeetCode.Solutions.Shared;

namespace LeetCode.Solutions;

internal class Solution1792 : IRunProgram
{
    public void Run()
    {

    }
    public double MaxAverageRatio(int[][] classes, int extraStudents)
    {
        var q = new PriorityQueue<int, double>();

        for (int i = 0; i < classes.Length; i++)
        {
            var perc = (double)classes[i][0] / classes[i][1];
            var pot_perc = (double)(classes[i][0] + 1) / (classes[i][1] + 1);
            q.Enqueue(i, -(pot_perc - perc));
        }

        for (; extraStudents > 0; extraStudents--)
        {
            int i = q.Dequeue();
            classes[i][0]++;
            classes[i][1]++;
            var perc = (double)classes[i][0] / classes[i][1];
            var pot_perc = (double)(classes[i][0] + 1) / (classes[i][1] + 1);
            q.Enqueue(i, -(pot_perc - perc));
        }

        double res = 0;
        while (q.Count > 0)
        {
            int i = q.Dequeue();
            res += (double)classes[i][0] / classes[i][1];
        }

        return res / classes.Length;
    }
}
