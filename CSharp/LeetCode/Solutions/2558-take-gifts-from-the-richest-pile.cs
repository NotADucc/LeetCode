using LeetCode.Solutions.Shared;

namespace LeetCode.Solutions;

internal class Solution2558 : IRunProgram
{
    public void Run()
    {
        
    }

    public long PickGifts(int[] gifts, int k) 
    {
        long res = 0;
        var q = new PriorityQueue<int, int>();

        foreach (int gift in gifts)
        {
            res += gift;
            q.Enqueue(gift, -gift);
        }

        for (; k > 0; k--)
        {
            int temp = q.Dequeue();
            int gift = (int)Math.Sqrt(temp);
            res -= temp - gift;
            q.Enqueue(gift, -gift);
        }

        return res;    
    }
}
