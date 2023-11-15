using LeetCode.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode._1Easy
{
    /*
    Cheese
    Runtime: 83ms 5.92%
    Memory: 36.48MB 95,45%

    Normal
    Runtime: 63ms 96.28%
    Memory: 37.03MB 16.39%
    */
    internal class DefangIPAddress : IRunProgram
    {
        private record Input(string Case, string Result);
        public void Run()
        {
            Input[] inputs = new Input[] 
            { 
                new Input("1.1.1.1","1[.]1[.]1[.]1")
                , new Input("255.100.50.0", "255[.]100[.]50[.]0")
            };
            foreach (var input in inputs)
            {
                Console.WriteLine(DefangIPaddr2(input.Case));
                Console.WriteLine(input.Result);
                Console.WriteLine();
            }
        }
        public string DefangIPaddr(string address)
        {
            return address.Replace(".", "[.]");
        }
        public string DefangIPaddr2(string address)
        {
            int l = address.Length;
            int j = 0;
            Span<char> output = stackalloc char[l + 6];
            for (int i = 0; i < l; i++, j++)
            {
                if (address[i].Equals('.'))
                {
                    output[j++] = '[';
                    output[j++] = '.';
                    output[j] = ']';
                    continue;
                }
                output[j] = address[i];
            }
            return output.ToString();
        }
    }
}
