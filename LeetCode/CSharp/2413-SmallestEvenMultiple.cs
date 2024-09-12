using LeetCode.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode._1Easy
{
    /*
    Runtime: 21ms 60.24%
    Memory: 26.5MB 73%
     */
    internal class SmallestEvenNumber : IRunProgram
    {
        private record Input(int Data, int Result);
        public void Run()
        {
            Input[] inputs = new Input[] 
            { 
                new Input(5, 10)
                ,new Input(6, 6)
            };

            foreach (var input in inputs)
            {
                Console.WriteLine(SmallestEvenMultiple(input.Data));
                Console.WriteLine(input.Result);
                Console.WriteLine();
            }
        }

        public int SmallestEvenMultiple(int n)
        {
            return ((n & 1) + 1) * n;
        }

        public int SmallestEvenMultipleternary(int n)
        {
            return (n & 1) == 0 ? n : n * 2;
        }
    }
}
