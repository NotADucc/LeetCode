using LeetCode.CSharp.Shared;
using LeetCode.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace LeetCode.CSharp
{
    internal class Solution0933: IRunProgram
    {
        public void Run()
        {
            
        }
    }

    public class RecentCounter
    {
        Queue<int> counter;
        public RecentCounter()
        {
            counter = new Queue<int>();
        }

        public int Ping(int t)
        {
            int low = Math.Max(t - 3_000, 0);
            while (counter.Count > 0 && counter.Peek() < low)
            {
                counter.Dequeue();
            }
            counter.Enqueue(t);
            return counter.Count;
        }
    }
}
