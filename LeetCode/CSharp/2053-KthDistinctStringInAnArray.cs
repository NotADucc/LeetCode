using LeetCode.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.CSharp
{
    internal class Solution2053 : IRunProgram
    {
        public void Run()
        {
            KthDistinct(["d", "b", "c", "b", "c", "a"], 2).Print();
        }
        public string KthDistinct(string[] arr, int k)
        {
            return arr
                .GroupBy(x => x)
                .Where(x => x.Count() == 1)
                .Skip(k - 1)
                .Select(x => x.Key)
                .FirstOrDefault() ?? string.Empty;
        }
    }
}
