using LeetCode.Solutions.Shared;

namespace LeetCode.Solutions;

internal class Solution1475 : IRunProgram
{
    public void Run()
    {

    }

    public int[] FinalPrices(int[] prices)
    {
        var stack = new Stack<int>();
        for (int i = 0; i < prices.Length; i++)
        {
            while (stack.Count > 0 && prices[stack.Peek()] >= prices[i])
            {
                prices[stack.Pop()] -= prices[i];
            }
            stack.Push(i);
        }

        return prices;
    }
}
