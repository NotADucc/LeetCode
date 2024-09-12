using LeetCode.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace LeetCode.CSharp
{
    internal class Solution0566 : IRunProgram
    {
        public void Run()
        {
            MatrixReshape([[1, 2], [3, 4]], 1, 4).Print();
            MatrixReshape([[1, 2], [3, 4]], 4, 1).Print();
        }
        public int[][] MatrixReshape(int[][] mat, int r, int c)
        {
            if (mat.Length == r || (mat.Length * mat[0].Length != r * c))
            {
                return mat;
            }
            int[][] output = new int[r][];

            for (int i = 0; i < mat.Length; i++)
            {
                for (int j = 0; j < mat[i].Length; j++)
                {
                    int index = i * mat[i].Length + j;

                    int row = index / c;
                    int col = index - (row * c);

                    if (output[row] is null)
                    {
                        output[row] = new int[c];
                    }

                    output[row][col] = mat[i][j];
                }
            }

            return output;
        }
    }
}
