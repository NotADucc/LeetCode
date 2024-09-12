using LeetCode.Shared;

namespace LeetCode.CSharp;

internal class Solution1476 : IRunProgram
{
    public void Run()
    {

    }
}
public class SubrectangleQueries
{
    private int[][] rect;
    public SubrectangleQueries(int[][] rectangle)
    {
        rect = rectangle;
    }

    public void UpdateSubrectangle(int row1, int col1, int row2, int col2, int newValue)
    {
        for (int row = row1; row <= row2; row++)
        {
            for (int col = col1; col <= col2; col++)
            {
                rect[row][col] = newValue;
            }
        }
    }

    public int GetValue(int row, int col)
    {
        return rect[row][col];
    }
}
