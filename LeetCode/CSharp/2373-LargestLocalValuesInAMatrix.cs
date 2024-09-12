using LeetCode.Shared;

namespace LeetCode.CSharp
{
    internal class Solution2373 : IRunProgram
    {
        public void Run()
        {
            LargestLocal([[9, 9, 8, 1], [5, 6, 2, 6], [8, 2, 6, 4], [6, 2, 2, 2]]).Print();
        }
        public int[][] LargestLocal(int[][] grid)
        {
            var maxLocal = new int[grid.Length - 2][];

            for (int i = 0; i < maxLocal.Length; i++)
            {
                maxLocal[i] = new int[grid.Length - 2];
                for (int j = 0; j < maxLocal.Length; j++)
                {
                    for (int ii = i; ii < 3 + i; ii++)
                    {
                        for (int jj = j; jj < 3 + j; jj++)
                        {
                            maxLocal[i][j] = Math.Max(maxLocal[i][j], grid[ii][jj]);
                        }
                    }
                }
            }

            return maxLocal;
        }
    }
}
