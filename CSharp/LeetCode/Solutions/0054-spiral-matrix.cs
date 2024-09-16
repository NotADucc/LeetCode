using LeetCode.Solutions.Shared;

namespace LeetCode.Solutions;

public class Solution0054 : IRunProgram
{
    public void Run()
    {
        SpiralOrder([[1, 2, 3], [4, 5, 6], [7, 8, 9]]).Print();
        SpiralOrder([[1, 2, 3, 4], [5, 6, 7, 8], [9, 10, 11, 12]]).Print();
    }

    public IList<int> SpiralOrder(int[][] matrix)
    {
        var output = new List<int>();

        (int y, int x)[] dirs = [(0, 1), (1, 0), (0, -1), (-1, 0)];
        int y_lower = 0, y_upper = matrix.Length, x_lower = 0, x_upper = matrix[0].Length;
        int dir = 0;
        (int y, int x) curr = (0, -1);
        int matrix_count = matrix.Length * matrix[0].Length;
        while (output.Count < matrix_count)
        {
            (int y, int x) pot = (curr.y + dirs[dir].y, curr.x + dirs[dir].x);

            if (pot.y < y_lower || pot.y >= y_upper || pot.x < x_lower || pot.x >= x_upper)
            {
                if (dir == 0)
                {
                    dir = 1;
                    y_lower++;
                }
                else if (dir == 1)
                {
                    dir = 2;
                    x_upper--;
                }
                else if (dir == 2)
                {
                    dir = 3;
                    y_upper--;
                }
                else
                {
                    dir = 0;
                    x_lower++;
                }
            }
            else
            {
                curr = pot;
                output.Add(matrix[curr.y][curr.x]);
            }
        }


        return output;
    }
}
