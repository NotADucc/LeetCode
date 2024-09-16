using LeetCode.Solutions.Shared;

namespace LeetCode.Solutions;

internal class Solution0874: IRunProgram
{
    public void Run()
    {
        RobotSim([4, -1, 3], []);
    }
    private const int MAGIC_SIZE = 3;

    public int RobotSim(int[] commands, int[][] obstacles)
    {
        int output = 0;
        int direction = 0;
        (int x, int y) curr_coord = (0, 0);
        var set = new HashSet<(int, int)>();
        foreach (var obstacle in obstacles)
        {
            set.Add((obstacle[0], obstacle[1]));
        }
        (int x, int y)[] changeCoords = new (int, int)[]
        {
        (0, 1),     // N
        (1, 0),     // E
        (0, -1),    // S
        (-1, 0)     // W
        };
        foreach (var command in commands)
        {
            if (command > 0)
            {
                for (int i = 0; i < command; i++)
                {
                    curr_coord.x += changeCoords[direction].x;
                    curr_coord.y += changeCoords[direction].y;
                    if (set.Contains(curr_coord))
                    {
                        curr_coord.x -= changeCoords[direction].x;
                        curr_coord.y -= changeCoords[direction].y;
                        break;
                    }
                }
                output = Math.Max(output, curr_coord.x * curr_coord.x + curr_coord.y * curr_coord.y);
            }
            else
            {
                direction = command == -1 ? (direction + 1) % 4 : direction - 1 < 0 ? 3 : direction - 1;
            }
        }
        return output;
    }
}
