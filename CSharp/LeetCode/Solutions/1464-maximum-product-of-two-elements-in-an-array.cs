using LeetCode.Solutions.Shared;

namespace LeetCode.Solutions;
internal class Solution1564 : IRunProgram
{
    public void Run()
    {

    }
    public int MaxProduct(int[] nums)
    {
        Span<int> ans = [nums[1], nums[0]];

        if (nums[0] > nums[1])
        {
            ans[0] = nums[0];
            ans[1] = nums[1];
        }

        for (int i = 2; i < nums.Length; i++)
        {
            int num = nums[i];
            if (num >= ans[0])
            {
                ans[1] = ans[0];
                ans[0] = num;
            }
            else if (num >= ans[1])
            {
                ans[1] = num;
            }
        }


        return (ans[0] - 1) * (ans[1] - 1);
    }

    public int MaxProductHeap(int[] nums)
    {
        var heap = new PriorityQueue<int, int>();
        for (int i = 0; i < nums.Length; i++)
        {
            int num = nums[i];
            heap.Enqueue(num, -num);
        }

        return (heap.Dequeue() - 1) * (heap.Dequeue() - 1);
    }
}
