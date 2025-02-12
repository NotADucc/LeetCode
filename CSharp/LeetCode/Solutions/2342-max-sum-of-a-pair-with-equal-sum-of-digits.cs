using LeetCode.Solutions.Shared;
using System.Text;

namespace LeetCode.Solutions;

internal class Solution2342 : IRunProgram
{
    public void Run()
    {

    }
    public int MaximumSum(int[] nums) 
    {
        int digit_sum(int num)
        {
            int res = 0;
            while (num > 0)
            {
                res += num % 10;
                num /= 10;
            }
            return res;
        }

        var dct = new SortedDictionary<int, PriorityQueue<int, int>>();
        int res = -1;
        foreach (int num in nums)
        {
            int new_num = digit_sum(num);
            int num_p = -new_num;
            
            dct.TryAdd(num_p, new PriorityQueue<int, int>());
            dct[num_p].Enqueue(num, -num);
            // dct[num_p].Enqueue(num, num);
            // if (dct[num_p].Count > 2)
            // {
            //     dct[num_p].Dequeue();
            // }
        }

        foreach (var kvp in dct)
        {
            var q = kvp.Value;
            if (q.Count < 2)
            {
                continue;
            }
            res = Math.Max(res, q.Dequeue() + q.Dequeue()); 
        }

        return res;
    }
}
