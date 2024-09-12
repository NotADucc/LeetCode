using LeetCode.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.CSharp
{
    internal class Solution0121 : IRunProgram
    {
        public void Run()
        {
            MaxProfit([7, 1, 5, 3, 6, 4]).Print();
            MaxProfit([7, 6, 4, 3, 1]).Print();
            MaxProfit([1]).Print();
            MaxProfit([2, 3, 4]).Print();
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
