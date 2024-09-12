using LeetCode.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.ExcelSheetColumnNumber
{
    public class Solution0168 : IRunProgram
    {
        private record Input(int Data, string Result);
        public void Run()
        {
            Input[] inputs = new Input[]
            {
                new Input(1, "A")
                , new Input(2, "B")
                , new Input(28, "AB")
                , new Input(701, "ZY")
                , new Input(70149123, "EWMDWE")
            };

            foreach (var input in inputs)
            {
                Console.WriteLine(ConvertToTitle(input.Data));
                Console.WriteLine(input.Result);
                Console.WriteLine();
            }
        }


        private const int _ASCII_BASE = 64;

        public string ConvertToTitle(int columnNumber)
        {
            string output = string.Empty;

            while (columnNumber > 0)
            {
                int rest = columnNumber % 26;
                rest = rest == 0 ? 26 : rest;
                output = (char)(rest + _ASCII_BASE) + output;

                columnNumber -= rest;
                columnNumber /= 26;
            }

            return output;
        }
    }
}
