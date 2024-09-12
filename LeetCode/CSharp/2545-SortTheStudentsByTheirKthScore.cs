using LeetCode.Shared;

namespace LeetCode.CSharp;

internal class Solution2545 : IRunProgram
{
    public void Run()
    {
        SortTheStudents([[3, 4], [5, 6]], 0).Print();
    }

    public int[][] SortTheStudents(int[][] score, int k)
    {
        PriorityQueue<int[], int> queue = new PriorityQueue<int[], int>();

        int i = 0;
        for (i = 0; i < score.Length; i++)
        {
            queue.Enqueue(score[i], score[i][k]);
        }

        while (queue.Count > 0)
        {
            score[--i] = queue.Dequeue();
        }

        return score;
    }
}
