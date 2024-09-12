using LeetCode.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.CSharp
{
    internal class Solution0200 : IRunProgram
    {
        public void Run()
        {
            NumIslands([
              ['1','1','1','1','0'],
              ['1','1','0','1','0'],
              ['1','1','0','0','0'],
              ['0','0','0','0','0']
            ]);
        }
        public int NumIslands(char[][] grid)
        {
            int islands = 0;
            for (int i = 0; i < grid.Length; i++)
            {
                for (int j = 0; j < grid[i].Length; j++)
                {
                    if (grid[i][j] != '1')
                    {
                        continue;
                    }

                    Explore(grid, i, j);
                    islands++;
                }
            }

            return islands;
        }

        private void Explore(char[][] grid, int i, int j)
        {
            if (grid[i][j] != '1')
            {
                return;
            }

            grid[i][j] = '2';

            if (i > 0)
            {
                Explore(grid, i - 1, j);
            }

            if (i < grid.Length - 1)
            {
                Explore(grid, i + 1, j);
            }

            if (j > 0)
            {
                Explore(grid, i, j - 1);
            }

            if (j < grid[i].Length - 1)
            {
                Explore(grid, i, j + 1);
            }
        }
    }
}
