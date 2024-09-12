using LeetCode.Shared;

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
            ]).Print();
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
            if (i < 0 || i >= grid.Length ||j < 0 || j >= grid[i].Length || grid[i][j] != '1')
            {
                return;
            }

            grid[i][j] = '2';

            Explore(grid, i - 1, j);
            Explore(grid, i + 1, j);
            Explore(grid, i, j - 1);
            Explore(grid, i, j + 1);
        }
    }
}
