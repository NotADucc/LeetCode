using LeetCode.Solutions.Shared;

namespace LeetCode.Solutions;

internal class Solution1926 : IRunProgram
{
    public void Run()
    {

    }

    public int NearestExit(char[][] maze, int[] entrance)
    {
        var q = new Queue<(int, int, int)>();
        q.Enqueue((entrance[0], entrance[1], 0));
        maze[entrance[0]][entrance[1]] = '+';
        while (q.Count > 0)
        {
            (int i, int j, int step) = q.Dequeue();
            if ((i == 0 || i == maze.Length - 1 || j == 0 || j == maze[i].Length - 1) && (i != entrance[0] || j != entrance[1]))
            {
                return step;
            }

            if (i - 1 >= 0 && maze[i - 1][j] != '+')
            {
                q.Enqueue((i - 1, j, step + 1));
                maze[i - 1][j] = '+';
            }
            if (i + 1 < maze.Length && maze[i + 1][j] != '+')
            {
                q.Enqueue((i + 1, j, step + 1));
                maze[i + 1][j] = '+';
            }
            if (j - 1 >= 0 && maze[i][j - 1] != '+')
            {
                q.Enqueue((i, j - 1, step + 1));
                maze[i][j - 1] = '+';
            }
            if (j + 1 < maze[i].Length && maze[i][j + 1] != '+')
            {
                q.Enqueue((i, j + 1, step + 1));
                maze[i][j + 1] = '+';
            }
        }

        return -1;
    }
}