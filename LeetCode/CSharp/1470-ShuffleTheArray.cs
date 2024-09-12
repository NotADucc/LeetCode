using LeetCode.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode._1Easy
{
    /*
    Runtime: 120ms 95.84%
    Memory: 44.61MB 86,69%
     */
    internal class ShuffleTheArray : IRunProgram
    {
        private record Data(int[] arr, int n);
        private record Input(Data Data, int[] Result);
        public void Run()
        {
            Input[] inputs = new Input[] 
            { 
                new Input(new Data(new int[]{ 2,5,1,3,4,7 }, 3), new int[]{ 2,3,5,4,1,7 })
            };

            foreach (var input in inputs)
            {
                Shuffle(input.Data.arr, input.Data.n).Print();
                input.Result.Print();
                Console.WriteLine();
            }
        }
        public int[] Shuffle(int[] nums, int n)
        {
            int[] output = new int[nums.Length];
            for (int i = 0, j = n; i < nums.Length; i+=2, j++)
            {
                output[i] = nums[j - n];
                output[i + 1] = nums[j];
            }
            return output;
        }
    }
}
