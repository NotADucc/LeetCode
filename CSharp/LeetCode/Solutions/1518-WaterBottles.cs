using LeetCode.Shared;

namespace LeetCode.CSharp;

internal class Solution1518 : IRunProgram
{
    public void Run()
    {
        NumWaterBottles(9, 3).Print();
    }
    public int NumWaterBottles(int numBottles, int numExchange)
    {
        int output = numBottles;

        while (numBottles >= numExchange)
        {
            int rest = numBottles % numExchange;
            numBottles /= numExchange;
            output += numBottles;
            numBottles += rest;
        }

        return output;
    }
}
