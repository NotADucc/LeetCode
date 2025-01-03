﻿using LeetCode.Solutions.Shared;

namespace LeetCode.Solutions;

internal class Solution2530 : IRunProgram
{
    public void Run()
    {

    }

    public long MaxKelements(int[] nums, int k)
    {
        PriorityQueue<int, int> queue = new PriorityQueue<int, int>(nums.Select(x => (x, x)), Comparer<int>.Create((a, b) => b - a));
        long output = 0L;

        for (int i = 0; i < k; i++)
        {
            int value = queue.Dequeue();
            output += value;
            value = (int)Math.Ceiling(value * 1.0 / 3);
            queue.Enqueue(value, value);
        }

        return output;
    }
}
