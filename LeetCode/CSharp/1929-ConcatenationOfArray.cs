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
    internal class Solution1929 : IRunProgram
    {
        public void Run()
        {
            GetConcatenation([1, 2, 1]).Print();
        }
        public int[] GetConcatenation(int[] nums)
        {
            var a = new int[nums.Length * 2];
            Array.Copy(nums, 0, a, 0, nums.Length);
            Array.Copy(nums, 0, a, nums.Length, nums.Length);
            return a;
        }
    }
}
