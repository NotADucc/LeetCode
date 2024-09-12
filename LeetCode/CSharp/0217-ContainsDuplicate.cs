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
        private record Input(int[] Data, bool Result);
        public void Run()
        {
            Input[] inputs = new Input[]
            {
                new Input(new int[]{ 1, 2, 3, 1}, true)
                ,new Input(new int[]{ 1, 0, 1, 1}, true)
                ,new Input(new int[]{ 1, 2, 3, 1, 2, 3}, false)
            };

            foreach (var input in inputs)
            {
                Console.WriteLine(ContainsDuplicate(input.Data));
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
