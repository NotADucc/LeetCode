using LeetCode.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode._1Easy
{
    internal class AddDigits : IRunProgram
    {
        private record Input(int Data, int Result);
        public void Run()
        {
            Input[] inputs = new Input[]
            {
                new Input(38, 2)
                , new Input(0, 0)
                , new Input(41, 5)
            };

            foreach (var input in inputs)
            {
                Console.WriteLine(Method(input.Data));
                Console.WriteLine(input.Result);
                Console.WriteLine();
            }
        }

        public int Method(int num)
        {
            //TODO: O(1)
            return 0;
        }
    }
}
