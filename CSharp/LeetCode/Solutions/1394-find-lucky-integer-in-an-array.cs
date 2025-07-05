using LeetCode.Solutions.Shared;

namespace LeetCode.Solutions;
internal class Solution1394 : IRunProgram
{
    public void Run()
    {
        FindLucky([2, 2, 3, 4]).Print();
        FindLucky([1, 2, 2, 3, 3, 3]).Print();
        FindLucky([2, 2, 2, 3, 3]).Print();
        FindLucky([1]).Print();
    }

    public int FindLucky(int[] arr)
    {
        var freq = new Dictionary<int, int>();
        foreach (int num in arr)
        {
            if (!freq.TryAdd(num, 1))
                freq[num]++;
        }
        int res = -1;
        foreach (var kvp in freq)
            res = kvp.Key == kvp.Value ? Math.Max(kvp.Key, res) : res;

        return res;
    }
}
