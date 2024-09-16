using LeetCode.Solutions.Shared;

namespace LeetCode.Solutions;

internal class Solution0442 : IRunProgram
{
    public void Run()
    {
        FindDuplicates([4, 3, 2, 7, 8, 2, 3, 1]).Print();
        FindDuplicates([1, 1, 2]).Print();
    }
    public IList<int> FindDuplicates(int[] nums)
    {
        var counter = new Dictionary<int, int>();

        foreach (var num in nums)
        {
            if (!counter.ContainsKey(num))
            {
                counter.Add(num, 0);
            }
            counter[num]++;
        }

        return counter.Where(x => x.Value > 1).Select(x => x.Key).ToList();
    }
}
