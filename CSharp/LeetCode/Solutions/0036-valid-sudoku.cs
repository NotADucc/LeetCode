using LeetCode.Solutions.Shared;

namespace LeetCode.Solutions;

public class Solution0036 : IRunProgram
{
    public void Run()
    {
        IsValidSudoku([
             ['5','3','.','.','7','.','.','.','.']
            ,['6','.','.','1','9','5','.','.','.']
            ,['.','9','8','.','.','.','.','6','.']
            ,['8','.','.','.','6','.','.','.','3']
            ,['4','.','.','8','.','3','.','.','1']
            ,['7','.','.','.','2','.','.','.','6']
            ,['.','6','.','.','.','.','2','8','.']
            ,['.','.','.','4','1','9','.','.','5']
            ,['.','.','.','.','8','.','.','7','9']
        ]);
    }

    private const int CHUNK_SIZE = 3;
    private const char EMPTY_VALUE = '.';
    public bool IsValidSudoku(char[][] board)
    {
        var rows = GenerateCollection();
        var columns = GenerateCollection();
        var chunks = GenerateCollection();

        for (int i = 0; i < board.Length; i++)
        {
            for (int j = 0; j < board[i].Length; j++)
            {
                char value = board[i][j];
                if (value == EMPTY_VALUE)
                {
                    continue;
                }
                int chunk = TranslateCoordToChunk(i, j);
                bool is_row_uq = rows[i].Add(value);
                bool is_column_uq = columns[j].Add(value);
                bool is_chunk_uq = chunks[chunk].Add(value);

                if (!is_row_uq || !is_column_uq || !is_chunk_uq)
                {
                    return false;
                }
            }
        }

        return true;
    }
    private HashSet<int>[] GenerateCollection() =>
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
    private int TranslateCoordToChunk(int row, int column)
    {
        row /= CHUNK_SIZE;
        column /= CHUNK_SIZE;

        return row * CHUNK_SIZE + column;
    }
}
