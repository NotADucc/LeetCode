using LeetCode.Solutions.Shared;

namespace LeetCode.Solutions;

internal class Solution2593 : IRunProgram
{
    public void Run()
    {

    }

	public long FindScore(int[] nums) 
    {
        long res = 0;
        var visited = new HashSet<int>();
        var q = new PriorityQueue<(int, int), (int, int)>(
            Comparer<(int, int)>.Create((a, b) => 
            {
                int cmp = a.Item1.CompareTo(b.Item1); 
                return cmp != 0 ? cmp : a.Item2.CompareTo(b.Item2);
            })
        );
        for (int i = 0; i < nums.Length; i++)
            q.Enqueue((nums[i], i), (nums[i], i));
        while (q.Count > 0)
        {
            var d = q.Dequeue();
            if (!visited.Add(d.Item2)) 
                continue;

            res += d.Item1;
            visited.Add(d.Item2 - 1);
            visited.Add(d.Item2 + 1);
        }

        return res;
    }
}
