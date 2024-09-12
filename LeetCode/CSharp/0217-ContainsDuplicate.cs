using LeetCode.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.ContainsDuplicate
{
    internal class Solution : IRunProgram
    {
        private record Input(int[] Data, int k, bool Result);
        public void Run()
        {
            Input[] inputs = new Input[]
            {
                new Input(new int[]{ 1, 2, 3, 1}, 3, true)
                ,new Input(new int[]{ 1, 0, 1, 1}, 1, true)
                ,new Input(new int[]{ 1, 2, 3, 1, 2, 3}, 2, false)
            };

            foreach (var input in inputs)
            {
                Console.WriteLine(ContainsDuplicate(input.Data, input.k));
                Console.WriteLine(input.Result);
                Console.WriteLine();
            }
        }

        public bool ContainsDuplicate(int[] nums)
        {
            return new HashSet<int>(nums).Count != nums.Length;
        }
    }
}
