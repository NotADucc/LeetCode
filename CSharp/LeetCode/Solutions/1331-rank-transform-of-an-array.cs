using LeetCode.Solutions.Shared;

namespace LeetCode.Solutions;

internal class Solution1331 : IRunProgram
{
    public void Run()
    {

    }
    public int[] ArrayRankTransform(int[] arr) 
    {
        // value: index
        // prio: val
        var q = new PriorityQueue<int, int>();
        for(int i = 0; i < arr.Length; i++)
        {
            q.Enqueue(i, arr[i]);
        }
        int last_element = int.MaxValue;
        int rank = 0;
        while(q.Count > 0)
        {
            int i = q.Dequeue();
            if (last_element != arr[i])
            {
                ++rank;
            }
            last_element = arr[i];
            arr[i] = rank;
        }

        return arr;
    }
}
