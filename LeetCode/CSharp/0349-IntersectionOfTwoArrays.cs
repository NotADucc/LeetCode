using LeetCode.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.CSharp
{
    internal class Solution0349 : IRunProgram
    {
        public void Run()
        {
            Intersection([1, 2, 2, 1], [2, 2]).Print();
        }

        public int[] Intersection(int[] i, int[] j)
        {
            return i.Where(x => j.Contains(x)).Distinct().ToArray();
        }
    }
}
