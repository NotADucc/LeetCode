using LeetCode.Solutions.Shared;

namespace LeetCode.Solutions;

internal class Solution2053 : IRunProgram
{
    public void Run()
    {
        KthDistinct(["d", "b", "c", "b", "c", "a"], 2).Print();
    }
    public string KthDistinct(string[] arr, int k)
    {
        return arr
            .GroupBy(x => x)
            .Where(x => x.Count() == 1)
            .Skip(k - 1)
            .Select(x => x.Key)
            .FirstOrDefault() ?? string.Empty;
    }
}
