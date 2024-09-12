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
    internal class Solution0807: IRunProgram
    {
        public void Run()
        {
            MaxIncreaseKeepingSkyline([ 
                [8, 4, 8, 7],
                [7, 4, 7, 7],
                [9, 4, 8, 7],
                [3, 3, 3, 3] 
            ]).Print();

            MaxIncreaseKeepingSkyline([[0, 0, 0], [0, 0, 0], [0, 0, 0]]).Print();
        }
        public int MaxIncreaseKeepingSkyline(int[][] grid)
        {
            var gridRow = new int[grid.Length];
            var gridColumn = new int[grid.Length];

            for (int row = 0; row < grid.Length; row++)
            {
                for (int column = 0; column < grid[row].Length; column++)
                {
                    gridRow[row] = Math.Max(gridRow[row], grid[row][column]);
                    gridColumn[column] = Math.Max(gridColumn[column], grid[row][column]);
                }
            }

            int combinedDelta = 0;
            for (int row = 0; row < grid.Length; row++)
            {
                for (int column = 0; column < grid[row].Length; column++)
                {
                    int maxheight = Math.Min(gridRow[row], gridColumn[column]);
                    combinedDelta += maxheight - grid[row][column];
                }
            }

            return combinedDelta;
        }
    }
}
