using LeetCode.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.CSharp
{
    internal class Solution0217 : IRunProgram
    {
        public void Run()
        {
            ContainsDuplicate([1, 2, 3, 1]).Print();
            ContainsDuplicate([1]).Print();
        }

        public bool ContainsDuplicate(int[] nums)
        {
            return new HashSet<int>(nums).Count != nums.Length;
        }
    }
}
