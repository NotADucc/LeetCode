using LeetCode.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.CSharp
{
    internal class Solution3239 : IRunProgram
    {
        public void Run()
        {
            MinFlips([[1, 0, 0], [0, 0, 0], [0, 0, 1]]).Print();
        }

        public int MinFlips(int[][] grid)
        {
            if (grid.Length <= 1 || grid[0].Length <= 1)
            {
                return 0;
            }

            int rowOutput = 0;
            int colOutput = 0;
            for (int i = 0; i < grid.Length; i++)
            {
                int leftRow = 0, rightRow = grid[i].Length - 1;

                while (leftRow < rightRow)
                {
                    if (grid[i][leftRow] != grid[i][rightRow])
                    {
                        rowOutput++;
                    }
                    leftRow++;
                    rightRow--;
                }
            }

            for (int i = 0; i < grid[0].Length; i++)
            {
                int leftCol = 0, rightCol = grid.Length - 1;

                while (leftCol < rightCol)
                {
                    if (grid[leftCol][i] != grid[rightCol][i])
                    {
                        colOutput++;
                    }
                    leftCol++;
                    rightCol--;
                }
            }


            return Math.Min(rowOutput, colOutput);
        }
    }
}
