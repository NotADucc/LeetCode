using LeetCode.Solutions.Shared;

namespace LeetCode.Solutions;

internal class Solution1861 : IRunProgram
{
    public void Run()
    {
        RotateTheBox([['#', '.', '#']]).Print();
    }
    public char[][] RotateTheBox(char[][] box)
    {
        char[][] res = new char[box[0].Length][];

        for (int i = 0; i < res.Length; i++)
            res[i] = new char[box.Length];

        for (int i = 0; i < box.Length; i++)
        {
            for (int j = 0; j < box[i].Length; j++)
            {
                int new_i = j;
                int new_j = res[0].Length - i - 1;
                res[new_i][new_j] = box[i][j];
            }
        }

        for (int i = 0; i < res[0].Length; i++)
        {
            for (int k = 0; k < res.Length; k++)
            {
                if (res[k][i] != '#') continue;
                int new_height = k;
                for (int j = k; j < res.Length; j++)
                {
                    if (res[j][i] == '#') continue;
                    else if (res[j][i] == '*') break;
                    new_height = j;
                }
                res[k][i] = '.';
                res[new_height][i] = '#';
            }
        }

        return res;
    }
}
