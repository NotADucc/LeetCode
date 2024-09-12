using LeetCode.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.CSharp
{
    public class Solution0037 : IRunProgram
    {
        public void Run()
        {
            SolveSudoku([['5', '3', '.', '.', '7', '.', '.', '.', '.'], ['6', '.', '.', '1', '9', '5', '.', '.', '.'], ['.', '9', '8', '.', '.', '.', '.', '6', '.'], ['8', '.', '.', '.', '6', '.', '.', '.', '3'], ['4', '.', '.', '8', '.', '3', '.', '.', '1'], ['7', '.', '.', '.', '2', '.', '.', '.', '6'], ['.', '6', '.', '.', '.', '.', '2', '8', '.'], ['.', '.', '.', '4', '1', '9', '.', '.', '5'], ['.', '.', '.', '.', '8', '.', '.', '7', '9']]);
        }
        private const int s_size = 9;
        private const int chunk_size = s_size / 3;
        public void SolveSudoku(char[][] board)
        {
            var rows = GenerateSets();
            var cols = GenerateSets();
            var chunks = GenerateSets();

            for (int i = 0; i < board.Length; i++)
            {
                for (int j = 0; j < board[i].Length; j++)
                {
                    if (board[i][j] != '.')
                    {
                        rows[i].Add(GiveDigit(board[i][j]));
                        cols[j].Add(GiveDigit(board[i][j]));
                        chunks[GiveChunk(i, j)].Add(GiveDigit(board[i][j]));
                    }
                }
            }

            Solve(board, rows, cols, chunks, 0, 0);
            board.Print();
        }

        private void Solve(
            char[][] board,
            HashSet<int>[] rows,
            HashSet<int>[] cols,
            HashSet<int>[] chunks,
            int i,
            int j
        )
        {
            if (j == s_size)
            {
                j = 0;
                i++;
            }

            if (i == s_size)
            {
                return;
            }

            if (board[i][j] == '.')
            {
                for (int k = 1; k < 10; k++)
                {
                    if (rows[i].Contains(k) || cols[j].Contains(k) || chunks[GiveChunk(i, j)].Contains(k))
                    {
                        continue;
                    }

                    board[i][j] = GiveChar(k);

                    rows[i].Add(k);
                    cols[j].Add(k);
                    chunks[GiveChunk(i, j)].Add(k);

                    Solve(board, rows, cols, chunks, i, j + 1);

                    if (rows[i].Count == 9 && cols[j].Count == 9 && chunks[GiveChunk(i, j)].Count == 9)
                    {
                        break;
                    }

                    board[i][j] = '.';
                    rows[i].Remove(k);
                    cols[j].Remove(k);
                    chunks[GiveChunk(i, j)].Remove(k);
                }
            }
            else
            {
                Solve(board, rows, cols, chunks, i, j + 1);
            }
        }

        private int GiveDigit(char ch) => ch - '0';
        private char GiveChar(int dig) => (char)(dig + '0');

        private int GiveChunk(int i, int j)
        {
            return ((i / chunk_size) * chunk_size) + (j / chunk_size);
        }

        private HashSet<int>[] GenerateSets()
        {
            return
                [
                    new HashSet<int>(),
                new HashSet<int>(),
                new HashSet<int>(),
                new HashSet<int>(),
                new HashSet<int>(),
                new HashSet<int>(),
                new HashSet<int>(),
                new HashSet<int>(),
                new HashSet<int>(),
            ];
        }
    }
}
