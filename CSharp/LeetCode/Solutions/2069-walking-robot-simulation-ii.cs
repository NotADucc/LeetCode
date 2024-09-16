using LeetCode.Solutions.Shared;

namespace LeetCode.Solutions;

internal class Solution2069 : IRunProgram
{
    public void Run()
    {

    }
}

public class Robot
{
    private int _bound_width;
    private int _bound_height;

    private int[] _current_coord;
    private static int[][] _moves = [[1, 0], [0, 1], [-1, 0], [0, -1]];
    private int _dir;

    private int _mod;
    public Robot(int width, int height)
    {
        _bound_width = width;
        _bound_height = height;

        _current_coord = [0, 0];
        _dir = 0;
        _mod = ((_bound_width - 1) << 1) + ((_bound_height - 1) << 1);
    }

    public void Step(int num)
    {
        num %= _mod;
        if (num == 0)
        {
            num += _mod;
        }
        while (num > 0)
        {
            int[] pot_coords = [_current_coord[0] + _moves[_dir][0], _current_coord[1] + _moves[_dir][1]];

            if (pot_coords[0] < 0 || pot_coords[0] >= _bound_width || pot_coords[1] < 0 || pot_coords[1] >= _bound_height)
            {
                _dir = (_dir + 1) % 4;
                continue;
            }

            _current_coord = pot_coords;
            num--;
        }
    }

    public int[] GetPos()
    {
        return _current_coord;
    }

    public string GetDir()
        => _dir switch
        {
            0 => "East",
            1 => "North",
            2 => "West",
            3 => "South",
        };
}
