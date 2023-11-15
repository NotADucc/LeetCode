using LeetCode.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode._1Easy
{
    /*
    Runtime: 21ms 75.00%
    Memory: 26.74MB 48.58%
     */
    internal class DivisibleAndNonDivisibleSumsDifference : IRunProgram
    {
        private record Data(int n, int m);
        private record Input(Data Data, int Result);
        public void Run()
        {
            Input[] inputs = new Input[] 
            { 
                new Input(new Data(10,3), 19)
                , new Input(new Data(5, 6), 15)
            };

            foreach (var input in inputs)
            {
                Console.WriteLine(DifferenceOfSums(input.Data.n, input.Data.m));
                Console.WriteLine(input.Result);
                Console.WriteLine();
            }
        }

        public int DifferenceOfSums(int n, int m)
        {
            int output = 0;
            for (int i = 1; i <= n; i++)
            {
                if (i % m == 0)
                {
                    output -= i;
                }
                else 
                {
                    output += i;
                }
            }
            return output;
        }
    }
}
