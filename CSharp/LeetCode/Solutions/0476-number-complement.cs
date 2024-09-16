using LeetCode.Solutions.Shared;

namespace LeetCode.Solutions;

internal class Solution0476 : IRunProgram
{
    public void Run()
    {
        FindComplement(5).Print();
        FindComplement(1).Print();
    }
    public int FindComplement(int num)
    {
        int multi = 1;
        int rest = 0;

        while (multi + rest < num)
        {
            rest += multi;
            multi <<= 1;
        }
        multi += rest;
        return multi ^ num;
    }
}
