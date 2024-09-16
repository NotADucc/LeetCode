using LeetCode.Solutions.Shared;

namespace LeetCode.Solutions;

internal class Solution0191 : IRunProgram
{
    public void Run()
    {
        HammingWeight(11).Print();
        HammingWeight(128).Print();
        HammingWeight(2147483645).Print();
    }
    public int HammingWeight(int n)
    {
        int count = 0;
        while (n > 0)
        {
            if ((n & 1) == 1) { count++; }
            n >>= 1;
        }
        return count;
    }
}
