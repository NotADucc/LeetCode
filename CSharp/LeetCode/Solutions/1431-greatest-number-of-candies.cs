using LeetCode.Solutions.Shared;

namespace LeetCode.Solutions;

internal class Solution1431 : IRunProgram
{
    public void Run()
    {
        KidsWithCandies([2, 3, 5, 1, 3], 3).Print();
    }
    public IList<bool> KidsWithCandies(int[] candies, int extraCandies)
    {
        List<bool> output = new List<bool>();
        int max = candies.Max();

        for (int i = 0; i < candies.Length; i++)
        {
            output.Add(candies[i] + extraCandies >= max);
        }

        return output;
    }
}
