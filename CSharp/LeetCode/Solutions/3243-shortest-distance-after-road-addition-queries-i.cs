using LeetCode.Solutions.Shared;
using System;

namespace LeetCode.Solutions
{
    internal class Solution3243 : IRunProgram
    {
        public void Run()
        {
            ShortestDistanceAfterQueries(5, [[2, 4], [0, 2], [0, 4]]).Print();
            ShortestDistanceAfterQueries(20, [[0, 9], [9, 17], [5, 11], [9, 12], [5, 17], [0, 8], [2, 8], [11, 14], [2, 14], [2, 16], [1, 3], [8, 15], [2, 5], [5, 8], [5, 16], [7, 12], [5, 15], [2, 17], [1, 8], [4, 14], [4, 13], [4, 8], [14, 16], [7, 18], [2, 9], [3, 7], [15, 18], [5, 13], [4, 11], [16, 18], [7, 16], [14, 19], [1, 7], [8, 11], [10, 18], [1, 4], [12, 19], [3, 19], [4, 19], [1, 19], [0, 3], [3, 15], [3, 17], [2, 6], [6, 19], [8, 10], [5, 7], [6, 9], [5, 14], [3, 14], [3, 9], [0, 12], [5, 10], [0, 2], [11, 13], [6, 11], [2, 7], [12, 16], [14, 17], [4, 16], [1, 15], [0, 19], [6, 17], [12, 18], [1, 11], [9, 18], [11, 19], [2, 12], [4, 17], [6, 16], [4, 6], [1, 18], [0, 5], [1, 13], [9, 19], [1, 14], [6, 10], [2, 13], [14, 18], [10, 15], [4, 12], [1, 6], [6, 12], [10, 19], [13, 19], [12, 14], [15, 17], [12, 15], [4, 7], [11, 15], [1, 9], [3, 16], [4, 15], [2, 18], [8, 13], [5, 12], [0, 6], [2, 4], [7, 17], [3, 8], [10, 16], [2, 11], [0, 16], [10, 17], [4, 9], [0, 7], [1, 17], [7, 11], [1, 10], [0, 18], [16, 19], [1, 12], [7, 14], [3, 6], [0, 13], [5, 9], [6, 14], [8, 17], [9, 15], [4, 10], [3, 11], [8, 18], [10, 14], [9, 11], [9, 14], [13, 18], [12, 17], [0, 17], [9, 16], [1, 16], [11, 17], [8, 19], [1, 5], [7, 9], [9, 13], [2, 15], [3, 5], [13, 16], [6, 13], [8, 14], [2, 19], [13, 17], [8, 12]]).Print();
        }

        public int[] ShortestDistanceAfterQueries(int n, int[][] queries)
        {
            var res = new int[queries.Length];
            var bfs = new int[n];
            var dag = new List<int>[n - 1];

            for (int i = 0; i < n - 1; i++)
            {
                dag[i] = new List<int>() { i + 1 };
                bfs[i + 1] = int.MaxValue;
            }

            for (int i = 0; i < queries.Length; i++)
            {
                dag[queries[i][0]].Add(queries[i][1]);
                var visited = new bool[n];
                var q = new Queue<int>();

                q.Enqueue(i == 0 ? 0 : queries[i][0]);

                while (q.Count > 0)
                {
                    int curr = q.Dequeue();
                    foreach (var next in dag[curr])
                    {
                        bfs[next] = Math.Min(bfs[next], bfs[curr] + 1);
                        if (!visited[next] && next < n - 1)
                        {
                            visited[next] = true;
                            q.Enqueue(next);
                        }
                    }
                }

                res[i] = bfs[^1];
            }


            return res;
        }
    }
}
