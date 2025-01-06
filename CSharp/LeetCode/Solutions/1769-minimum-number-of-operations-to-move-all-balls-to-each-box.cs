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
            if (boxes[i] == '1')
            {
                for (int j = 0; j < boxes.Length; j++)
                {
                    res[j] += Math.Abs(i - j);
                }
            }
        }

        return res;
    }
}
