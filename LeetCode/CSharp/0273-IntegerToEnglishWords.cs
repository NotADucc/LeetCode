using LeetCode.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.CSharp
{
    internal class Solution0273 : IRunProgram
    {
        public void Run()
        {
            NumberToWords(0).Print();
            NumberToWords(1).Print();
            NumberToWords(1_00).Print();
            NumberToWords(1_01).Print();
            NumberToWords(1_000).Print();
            NumberToWords(1_001).Print();
            NumberToWords(1_000_001).Print();
            NumberToWords(1_000_000_001).Print();
            NumberToWords(1_310_056_101).Print();
        }

        public string NumberToWords(int num)
        {
            if (num == 0)
            {
                return "Zero";
            }

            StringBuilder sb = new StringBuilder();
            Helper(num, sb, 1_000_000_000);
            return sb.ToString().TrimStart();
        }

        private void Helper(int current, StringBuilder sb, int divisor)
        {
            if (current < 20)
            {
                sb.Append(Glossary(current));
            }
            else if (current < 100)
            {
                int temp = current / 10 * 10;
                int rest = current % 10;
                sb.Append(Glossary(temp));
                Helper(rest, sb, 1000);
            }
            else
            {
                int quotient = current / divisor;
                current = current % divisor;
                if (quotient > 0)
                {
                    Helper(quotient, sb, 1000);
                    sb.Append(Glossary(divisor));
                }

                Helper(current, sb, NextDivisor(divisor));
            }
        }

        private int NextDivisor(int divisor) => divisor switch
        {
            1_000_000_000 => 1_000_000,
            1_000_000 => 1_000,
            1_000 => 100,
            100 => 100,
        };

        private ReadOnlySpan<char> Glossary(int num) => num switch
        {
            0 => string.Empty,
            1 => " One",
            2 => " Two",
            3 => " Three",
            4 => " Four",
            5 => " Five",
            6 => " Six",
            7 => " Seven",
            8 => " Eight",
            9 => " Nine",
            10 => " Ten",
            11 => " Eleven",
            12 => " Twelve",
            13 => " Thirteen",
            14 => " Fourteen",
            15 => " Fifteen",
            16 => " Sixteen",
            17 => " Seventeen",
            18 => " Eighteen",
            19 => " Nineteen",
            20 => " Twenty",
            30 => " Thirty",
            40 => " Forty",
            50 => " Fifty",
            60 => " Sixty",
            70 => " Seventy",
            80 => " Eighty",
            90 => " Ninety",
            100 => " Hundred",
            1_000 => " Thousand",
            1_000_000 => " Million",
            1_000_000_000 => " Billion",
        };
    }
}
