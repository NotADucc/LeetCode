using LeetCode.Solutions.Shared;

namespace LeetCode.Solutions;

internal class Solution1769 : IRunProgram
{
    public void Run()
    {

    }

    public int[] MinOperations(string boxes)
    {
        int[] res = new int[boxes.Length];

        for (int i = 0; i < boxes.Length; i++)
        {
            for (int j = 0; j < boxes.Length; j++)
            {
                res[i] += boxes[j] == '1' ? Math.Abs(i - j) : 0;
            }
        }

        return res;
    }
}
