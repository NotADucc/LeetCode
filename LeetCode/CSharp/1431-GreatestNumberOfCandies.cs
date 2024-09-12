using LeetCode.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.CSharp
{
    internal class Solution1431 : IRunProgram
    {
        private record Data(int[] arr, int e);
        private record Input(Data Data, IList<bool> Result);
        public void Run()
        {
            Input[] inputs = new Input[]
            {
                new Input(new Data(new int[]{ 2,3,5,1,3 }, 3), new List<bool>(){true,true,true,false,true })
                ,
            };

            foreach (var input in inputs)
            {
                KidsWithCandies(input.Data.arr, input.Data.e).Print();
                input.Result.Print();
                Console.WriteLine();
            }
        }
        public IList<bool> KidsWithCandies(int[] candies, int extraCandies)
        {
            List<bool> output = new List<bool>();
            int max = candies.Max();

            for (int i = 0; i < candies.Length; i++)
            {
                output.Add(candies[i] + extraCandies >= max);
            }

            return output;
        }
    }
}
