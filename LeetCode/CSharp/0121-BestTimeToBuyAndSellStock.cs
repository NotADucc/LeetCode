using LeetCode.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.BestTimeToBuyAndSellStock
{
    internal class Solution : IRunProgram
    {
        private record Input(int[] Data, int Result);
        public void Run()
        {
            Input[] inputs = new Input[]
            {
                new Input(new int[]{ 7, 1, 5, 3, 6, 4 }, 5)
                ,new Input(new int[]{ 7, 6, 4, 3, 1 }, 0)
                ,new Input(new int[]{ 1 }, 0)
                ,new Input(new int[]{ 2, 3, 4 }, 2)
                ,new Input(new int[]{ 2, 1, 4 }, 3)
                ,new Input(new int[]{ 2, 5, 1, 2, 4 }, 3)
                ,new Input(new int[]{ 2, 4, 1 }, 2)
                ,new Input(new int[]{ 3, 2, 6, 5, 0, 3 }, 4)
            };

            foreach (var input in inputs)
            {
                Console.WriteLine(MaxProfit(input.Data));
                Console.WriteLine(input.Result);
                Console.WriteLine();
            }
        }
        public int MaxProfit(int[] prices)
        {
            int lowest_day = prices[0];
            int maximum_profit = 0;

            foreach (var price in prices)
            {
                maximum_profit = Math.Max(maximum_profit, price - lowest_day);
                lowest_day = Math.Min(lowest_day, price);
            }
            return maximum_profit;
        }

        public int MaxProfitBrute(int[] prices) 
        {
            //brute force, wanted to see if it would work
            //TLE
            int l = prices.Length, profit = 0;
            for (int i = 0; i < l; i++)
            {
                for (int j = i; j < l; j++)
                {
                    profit = Math.Max(profit, prices[j] - prices[i]);
                }
            }
            return profit;
        }
    }
}
