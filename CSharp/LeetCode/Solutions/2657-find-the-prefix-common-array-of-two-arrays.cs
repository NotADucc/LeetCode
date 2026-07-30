using LeetCode.Solutions.Shared;

namespace LeetCode.Solutions;
internal class Solution2657 : IRunProgram
{
    public void Run()
    {

    }
    public int[] FindThePrefixCommonArray(int[] A, int[] B)
    {
        int n = A.Length;
        int[] res = new int[n];
        Span<int> freq = stackalloc int[n + 1];

        for (int i = 0; i < n; i++)
        {
            int a = A[i], b = B[i];
            freq[a]++;
            freq[b]++;
            foreach (var val in freq)
            {
                if (val >= 2)
                    res[i]++;
            }
        }

        return res;
    }

    public int[] FindThePrefixCommonArraySomeoneElseSolution(int[] A, int[] B)
    {
        int n = A.Length, common = 0;
        int[] res = new int[n];
        Span<int> freq = stackalloc int[n + 1];
        for (int i = 0; i < n; i++)
        {
            int a = A[i], b = B[i];
            if (++freq[a] == 2)
                common++;
            if (++freq[b] == 2)
                common++;
            res[i] = common;
        }

        return res;
    }
}
