using LeetCode.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.CSharp
{
    internal class Solution1207 : IRunProgram
    {
        public void Run()
        {
            UniqueOccurrences([1, 2, 2, 1, 1, 3]).Print();
        }
        public bool UniqueOccurrences(int[] arr)
        {
            var dct = new Dictionary<int, int>();
            foreach (int i in arr)
            {
                dct.TryAdd(i, 0);
                dct[i]++;
            }

            return new HashSet<int>(dct.Values).Count == dct.Values.Count;
        }
    }
}
