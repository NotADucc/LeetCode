using LeetCode.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.CSharp
{
    public class Solution0079 : IRunProgram
    {
        public void Run()
        {
            Exist([['A', 'B', 'C', 'E'], ['S', 'F', 'C', 'S'], ['A', 'D', 'E', 'E']], "ABCCED");
        }

        public bool Exist(char[][] board, string word)
        {
            for (int i = 0; i < board.Length; i++)
            {
                for (int j = 0; j < board[i].Length; j++)
                {
                    if (Helper(board, word, 0, i, j))
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        private bool Helper(char[][] board, string word, int index = 0, int row = 0, int col = 0)
        {
            if (row < 0 || col < 0 || row >= board.Length || col >= board[row].Length || board[row][col] == '.' || word[index] != board[row][col])
            {
                return false;
            }

            index++;
            char temp = board[row][col];
            board[row][col] = '.';

            if (word.Length == index)
            {
                return true;
            }

            bool res = Helper(board, word, index, row - 1, col)
                || Helper(board, word, index, row + 1, col)
                || Helper(board, word, index, row, col - 1)
                || Helper(board, word, index, row, col + 1);

            board[row][col] = temp;

            return res;
        }
    }
}
