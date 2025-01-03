using LeetCode.Solutions.Shared;

namespace LeetCode.Solutions;

internal class Solution0052 : IRunProgram
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
        List<int> col = new List<int>(n);
        List<int> diag1 = new List<int>(n);
        List<int> diag2 = new List<int>(n);

        return Backtrack(col, diag1, diag2, n, 0, n);
    }

    private int Backtrack(List<int> col, List<int> diag1, List<int> diag2, int grid_size, int row, int queens_left)
    {
        if (queens_left == 0)
        {
            return 1;
        }
        else
        {
            int res = 0;
            for (int c = 0; c < grid_size; c++)
            {
                if (CanPlace(col, diag1, diag2, row, c))
                {
                    Place(col, diag1, diag2, row, c);
                    res += Backtrack(col, diag1, diag2, grid_size, row + 1, queens_left - 1);
                    Remove(col, diag1, diag2, row, c);
                }
            }
            return res;
        }
    }
    private bool CanPlace(List<int> col, List<int> diag1, List<int> diag2, int r, int c)
    {
        return !col.Contains(c) && !diag1.Contains(r + c) && !diag2.Contains(r - c);
    }
    private void Place(List<int> col, List<int> diag1, List<int> diag2, int r, int c)
    {
        col.Add(c);
        diag1.Add(r + c);
        diag2.Add(r - c);
    }
    private void Remove(List<int> col, List<int> diag1, List<int> diag2, int r, int c)
    {
        col.Remove(c);
        diag1.Remove(r + c);
        diag2.Remove(r - c);
    }
}
