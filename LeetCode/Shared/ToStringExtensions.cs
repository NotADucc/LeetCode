using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Shared
{
    public static class ToStringExtensions
    {
        public static void Print(this int[] input) 
        {
            if (input is null)
            {
                return;
            }

            if (input.Length == 0)
            {
                return;
            }

            for (int i = 0; i < input.Length - 1; i++)
            {
                Console.Write($"{input[i]}, ");
            }

            Console.WriteLine(input[^1]);
        }
    }
}
