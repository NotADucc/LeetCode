using LeetCode.Solutions.Shared;

namespace LeetCode.Solutions;

internal class Solution1381 : IRunProgram
{
    public void Run()
    {
        
    }
    internal class CustomStack
    {
        private int[] arr;
        private int max;
        private int curr;
        public CustomStack(int maxSize)
        {
            curr = -1;
            max = maxSize;
            arr = new int[max];
        }

        public void Push(int x)
        {
            if (curr + 1 >= max) return;
            arr[curr + 1] = x;
            curr++;
        }

        public int Pop()
        {
            if (curr < 0) return -1;
            return arr[curr--];
        }

        public void Increment(int k, int val)
        {
            int len = Math.Min(k, max);
            for (int i = 0; i < len; i++)
            {
                arr[i] += val;
            }
        }
    }
}
