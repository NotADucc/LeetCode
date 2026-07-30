using LeetCode.Solutions.Shared;

namespace LeetCode.Solutions;
internal class Solution0506 : IRunProgram
{
    public void Run()
    {

    }

    public string[] FindRelativeRanks(int[] score)
    {
        PriorityQueue<int, int> heap = new PriorityQueue<int, int>();
        int n = score.Length;
        for (int i = 0; i < n; i++)
            heap.Enqueue(i, -score[i]);

        string[] ans = new string[n];
        for (int placement = 1; heap.Count > 0; placement++)
        {
            int idx = heap.Dequeue();
            string answer = placement switch
            {
                1 => "Gold Medal",
                2 => "Silver Medal",
                3 => "Bronze Medal",
                _ => $"{placement}",
            };
            ans[idx] = answer;
        }

        return ans;
    }
}
