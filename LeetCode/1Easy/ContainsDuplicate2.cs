using LeetCode.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode._1Easy
{
    public class ContainsDuplicate2 : IRunProgram
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
                Console.WriteLine(ContainsNearbyDuplicate(input.Data, input.k));
                Console.WriteLine(input.Result);
                Console.WriteLine();
            }
        }

        public bool ContainsNearbyDuplicate(int[] nums, int k)
        {
            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = i + 1; j < nums.Length && Math.Abs(i - j) <= k; j++)
                {
                    if (nums[i] == nums[j])
                    {
                        return true;
                    }
                }
            }

            return false;
        }
    }
}
