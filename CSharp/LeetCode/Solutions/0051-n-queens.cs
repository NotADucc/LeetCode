using LeetCode.Solutions.Shared;

namespace LeetCode.Solutions;

public class Solution0051 : IRunProgram
{
    public void Run()
    {
        SolveNQueens(1).PrintNested();
        SolveNQueens(2).PrintNested();
        SolveNQueens(3).PrintNested();
        SolveNQueens(4).PrintNested();
        SolveNQueens(5).PrintNested();
        SolveNQueens(6).PrintNested();
        SolveNQueens(7).PrintNested();
        SolveNQueens(8).PrintNested();
        SolveNQueens(9).PrintNested();
    }

    public IList<IList<string>> SolveNQueens(int n)
    {
        var output = new List<IList<string>>();
        var grid = new char[n][];

        for (int i = 0; i < n; i++) grid[i] = Enumerable.Repeat('.', n).ToArray();

        Helper(output, grid, 0, n, n);

        return output;
    }

    private void Helper(List<IList<string>> output, char[][] grid, int row, int grid_size, int queens_left)
    {
        if (queens_left == 0)
        {
            output.Add(grid.Select(x => new string(x)).ToList());
        }
        else
        {
            for (int i = 0; i < grid_size; i++)
            {
                if (CanPlace(grid, grid_size, row, i))
                {
                    grid[row][i] = 'Q';
                    Helper(output, grid, row + 1, grid_size, queens_left - 1);
                    grid[row][i] = '.';
                }
            }
        }
    }

    private unsafe bool CanPlace(char[][] grid, int grid_size, int row, int col)
    {
        // col
        for (int i = 0; i < row; i++)
        {
            if (grid[i][col] == 'Q')
            {
                return false;
            }
        }

        (int d_row, int d_col) = (row - 1, col - 1);
        while (d_row >= 0 && d_col >= 0)
        {
            if (grid[d_row--][d_col--] == 'Q')
            {
                return false;
            }
        }

        (d_row, d_col) = (row - 1, col + 1);

        while (d_row >= 0 && d_col < grid_size)
        {
            if (grid[d_row--][d_col++] == 'Q')
            {
                return false;
            }
        }

        return true;
    }
}
