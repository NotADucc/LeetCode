using LeetCode.Solutions.Shared;

namespace LeetCode.Solutions;

internal class Solution0509 : IRunProgram
{
    public void Run()
    {
        Fib(2).Print();
    }



    public int Fib(int n)
    {
        int seq1 = 0;
        int seq2 = 1;

        for (int i = 0; i < n; i++)
        {
            int temp = seq1;
            seq1 = seq2;
            seq2 += temp;
        }

        return seq1;
    }


    public int FibRec(int n)
    {
        int[] mem = new int[n];
        return F(n, mem);
    }
    private int F(int n, int[] mem)
    {
        if (n <= 0) { return 0; }
        else if (n == 1) { return 1; }
        else if (mem[n - 1] == 0) { mem[n - 1] = F(n - 1, mem) + F(n - 2, mem); }

        return mem[n - 1];
    }
}
