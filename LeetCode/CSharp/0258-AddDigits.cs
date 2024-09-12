using LeetCode.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
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
                Console.WriteLine(AddDigits(input.Data));
                Console.WriteLine(input.Result);
                Console.WriteLine();
            }
        }

        public int AddDigits(int num)
        {
            int output = 0;
            while (num > 0)
            {
                output += num % 10;
                num /= 10;

                if (num == 0 && output >= 10)
                {
                    num = output;
                    output = 0;
                }
            }
            return output;
        }
    }
}
