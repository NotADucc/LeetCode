using LeetCode.Solutions.Shared;

namespace LeetCode.Solutions;

internal class Solution1137 : IRunProgram
{
    public void Run()
    {
        Tribonacci(2).Print();
        Tribonacci(22).Print();
    }
    public int Tribonacci(int n)
    {
        int[] mem = new int[n];
        return Recursive(n, mem);
    }

    private int Recursive(int n, int[] mem)
    {
        if (n <= 0)
        {
            return 0;
        }
        else if (n == 1)
        {
            return 1;
        }
        else if (mem[n - 1] != 0)
        {
            return mem[n - 1];
        }
        else
        {
            mem[n - 1] = Recursive(n - 1, mem) + Recursive(n - 2, mem) + Recursive(n - 3, mem);
            return mem[n - 1];
        }
    }
}
