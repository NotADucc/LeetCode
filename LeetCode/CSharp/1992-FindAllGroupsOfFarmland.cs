using LeetCode.Shared;

namespace LeetCode.CSharp
{
    internal class Solution1992 : IRunProgram
    {
        public void Run()
        {
            FindFarmland([[1, 0, 0], [0, 1, 1], [0, 1, 1]]).Print();
            FindFarmland([[1, 1], [1, 1]]).Print();
        }
        public int[][] FindFarmland(int[][] land)
        {
            var output = new List<int[]>();
            for (int i = 0; i < land.Length; i++)
            {
                for (int j = 0; j < land[i].Length; j++)
                {
                    if (land[i][j] != 1)
                    {
                        continue;
                    }

                    int end_i = i;
                    int end_j = j;

                    Helper(land, i, j, ref end_i, ref end_j);

                    output.Add([i, j, end_i, end_j]);
                }
            }
            return output.ToArray();
        }

        private void Helper(int[][] land, int i, int j, ref int i_end, ref int j_end)
        {
            if (i < 0 || j < 0 || i >= land.Length || j >= land[i].Length || land[i][j] != 1)
            {
                return;
            }

            land[i][j] = 2;

            i_end = Math.Max(i_end, i);
            j_end = Math.Max(j_end, j);

            Helper(land, i - 1, j, ref i_end, ref j_end);
            Helper(land, i + 1, j, ref i_end, ref j_end);
            Helper(land, i, j - 1, ref i_end, ref j_end);
            Helper(land, i, j + 1, ref i_end, ref j_end);
        }
    }
}
