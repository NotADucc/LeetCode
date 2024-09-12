using LeetCode.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.CSharp
{
    internal class Solution1672 : IRunProgram
    {
        private record Input(int[][] Data, int Result);

        public void Run()
        {
            Input[] inputs = new Input[]
            {
                new Input(new int[][]{ new int[]{ 1, 2, 3 }, new int[] { 3, 2, 1} }, 6)
                ,new Input(new int[][]{ new int[]{ 1, 2, 3 }, new int[] { 3, 2, 2} }, 7)
            };

            foreach (var input in inputs)
            {
                Console.WriteLine(MaximumWealthNoBuiltInMethods(input.Data));
                Console.WriteLine(input.Result);
                Console.WriteLine();
            }
        }

        public int MaximumWealth(int[][] accounts)
        {
            int l = accounts.Length;
            int[] totals = new int[l];

            for (int i = 0; i < l; i++)
            {
                totals[i] = accounts[i].Sum();
            }

            return totals.Max();
        }

        public int MaximumWealthNoBuiltInMethods(int[][] accounts)
        {
            int l = accounts.Length;
            int max = int.MinValue;

            for (int i = 0; i < l; i++)
            {
                int temp = SumArray(accounts[i]);
                if (temp > max)
                {
                    max = temp;
                }
            }

            return max;
        }
        public int SumArray(int[] arr) 
        {
            var vSize = Vector<int>.Count;
            int result = 0;
            int i = 0;
            for (; i <= arr.Length - vSize; i += vSize)
            {
                var v1 = new Vector<int>(arr, i);
                result += Vector.Sum<int>(v1);
            }
            for (; i < arr.Length; i++)
            {
                result += arr[i];
            }
            return result;
        }
    }
}
