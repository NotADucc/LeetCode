using LeetCode.CSharp.Shared;
using LeetCode.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace LeetCode.CSharp
{
    internal class Solution0840: IRunProgram
    {
        public void Run()
        {
            NumMagicSquaresInside([[4, 3, 8, 4], [9, 5, 1, 9], [2, 7, 6, 2]]).Print();
        }
        private const int MAGIC_SIZE = 3;

        public int NumMagicSquaresInside(int[][] grid)
        {
            int output = 0;
            for (int i = 0; i + MAGIC_SIZE - 1 < grid.Length; i++)
            {
                for (int j = 0; j + MAGIC_SIZE - 1 < grid[i].Length; j++)
                {
                    if (Helper(grid, i, j))
                    {
                        output++;
                    }
                }
            }

            return output;
        }

        private bool Helper(int[][] grid, int i, int j)
        {
            int sum = grid[i][j] + grid[i][j + 1] + grid[i][j + 2];
            HashSet<int> set = new HashSet<int>(9);

            for (int row = 0; row < MAGIC_SIZE; row++)
            {
                int temp_sum_row = 0;
                int temp_sum_col = 0;
                for (int col = 0; col < MAGIC_SIZE; col++)
                {
                    if (set.Contains((grid[i + row][j + col])))
                    {
                        return false;
                    }
                    if (grid[i + row][j + col] > 9 || grid[i + row][j + col] <= 0)
                    {
                        return false;
                    }
                    temp_sum_row += grid[i + row][j + col];
                    temp_sum_col += grid[i + col][j + row];
                    set.Add(grid[i + row][j + col]);
                }
                if (sum != temp_sum_row || sum != temp_sum_col)
                {
                    return false;
                }
            }
            if (
                grid[i + 1][j + 1] == grid[i + 2][j + 2]
                || grid[i + 2][j] == grid[i + 1][j + 1]
                || grid[i + 2][j] == grid[i][j + 2]
                || grid[i + 1][j + 1] == grid[i][j + 2]
            )
            {
                return false;
            }

            if (
                grid[i][j] + grid[i + 1][j + 1] + grid[i + 2][j + 2]
                != grid[i][j + 2] + grid[i + 1][j + 1] + grid[i + 2][j]
            )
            {
                return false;
            }

            return true;
        }
    }
}
