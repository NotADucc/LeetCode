using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Shared
{
    public static class ToStringExtensions
    {
        public static void Print<T>(this T input)
        {
            Console.WriteLine(input);
        }
        public static void Print<T>(this T[] input)
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

        public static void Print<T>(this T[][] input)
        {
            if (input is null)
            {
                return;
            }

            if (input.Length == 0)
            {
                return;
            }

            for (int i = 0; i < input.Length; i++)
            {
                input[i].Print();
            }
        }

        public static void PrintNested<T>(this IEnumerable<IEnumerable<T>> input)
        {
            if (input is null)
            {
                return;
            }

            if (input.Count() == 0)
            {
                return;
            }

            foreach (var item in input) 
            { 
                item.Print();
            }
            Console.WriteLine();
        }

        public static void Print<T>(this IEnumerable<T> input)
        {
            if (input is null)
            {
                return;
            }

            if (input.Count() == 0)
            {
                return;
            }

            Console.WriteLine(string.Join(", ", input.Select(x => x)));
        }
    }
}
