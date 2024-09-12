using LeetCode.Shared;

namespace LeetCode.CSharp;

internal class Solution2326 : IRunProgram
{
    public void Run()
    {
        SpiralMatrix(3, 2, ListNodeHelper.New(13)).Print();
    }

    public int[][] SpiralMatrix(int m, int n, ListNode head)
    {
        var output = new int[m][];

        for (int i = 0; i < m; i++) output[i] = Enumerable.Repeat(-1, n).ToArray();

        (int y, int x)[] dirs = [(0, 1), (1, 0), (0, -1), (-1, 0)];
        int y_lower = 0, y_upper = m, x_lower = 0, x_upper = n;
        int dir = 0;

        (int y, int x) current_pos = (0, -1);
        while (head is not null)
        {
            (int y, int x) pot_pos = (current_pos.y + dirs[dir].y, current_pos.x + dirs[dir].x);

            if (pot_pos.y < y_lower || pot_pos.y >= y_upper || pot_pos.x < x_lower || pot_pos.x >= x_upper)
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
                current_pos = pot_pos;
                output[current_pos.y][current_pos.x] = head.val;
                head = head.next;
            }
        }

        return output;
    }
}
