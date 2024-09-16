using LeetCode.Solutions.Shared;

namespace LeetCode.Solutions;

public class Solution0052 : IRunProgram
{
    public void Run()
    {
        TotalNQueens(1).Print();
        TotalNQueens(2).Print();
        TotalNQueens(3).Print();
        TotalNQueens(4).Print();
        TotalNQueens(5).Print();
        TotalNQueens(6).Print();
        TotalNQueens(7).Print();
        TotalNQueens(8).Print();
        TotalNQueens(9).Print();
    }

    public int TotalNQueens(int n)
    {
        int output = 0;

        HashSet<int> v_column = new HashSet<int>();
        HashSet<int> v_diag_1 = new HashSet<int>();
        HashSet<int> v_diag_2 = new HashSet<int>();
        Helper(v_column, v_diag_1, v_diag_2, 0, n, n, ref output);

        return output;
    }

    private void Helper(HashSet<int> v_column, HashSet<int> v_diag_1, HashSet<int> v_diag_2, int row, int grid_size, int queens_left, ref int output)
    {
        if (queens_left == 0)
        {
            output++;
        }
        else
        {
            for (int i = 0; i < grid_size; i++)
            {
                if (CanPlace(v_column, v_diag_1, v_diag_2, row, i))
                {
                    AddVisited(v_column, v_diag_1, v_diag_2, row, i);
                    Helper(v_column, v_diag_1, v_diag_2, row + 1, grid_size, queens_left - 1, ref output);
                    RemoveVisited(v_column, v_diag_1, v_diag_2, row, i);
                }
            }
        }
    }
    private void AddVisited(HashSet<int> v_column, HashSet<int> v_diag_1, HashSet<int> v_diag_2, int row, int col)
    {
        v_column.Add(col);
        v_diag_1.Add(row - col);
        v_diag_2.Add(row + col);
    }
    private void RemoveVisited(HashSet<int> v_column, HashSet<int> v_diag_1, HashSet<int> v_diag_2, int row, int col)
    {
        v_column.Remove(col);
        v_diag_1.Remove(row - col);
        v_diag_2.Remove(row + col);
    }
    private bool CanPlace(HashSet<int> v_column, HashSet<int> v_diag_1, HashSet<int> v_diag_2, int row, int col)
    {
        return !v_column.Contains(col) && !v_diag_1.Contains(row - col) && !v_diag_2.Contains(row + col);
    }
}
