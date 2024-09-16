using LeetCode.Solutions.Shared;

namespace LeetCode.Solutions;

internal class Solution2305 : IRunProgram
{
    public void Run()
    {
        DistributeCookies([8, 15, 10, 20, 8], 2).Print();
    }

    public int DistributeCookies(int[] cookies, int k)
    {
        int output = int.MaxValue, max = 0;
        int[] children = new int[k];
        Helper(ref output, cookies, children, max, 0);
        return output;
    }

    private void Helper(ref int output, int[] cookies, int[] children, int max, int index)
    {
        if (cookies.Length == index)
        {
            output = Math.Min(output, max);
        }
        else
        {
            for (int j = 0; j < children.Length; j++)
            {
                unsafe
                {
                    children[j] += cookies[index];
                    int temp_max = Math.Max(max, children[j]);
                    Helper(ref output, cookies, children, temp_max, index + 1);
                    children[j] -= cookies[index];
                }
            }
        }
    }
}
