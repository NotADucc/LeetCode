using LeetCode.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.CSharp
{
    internal class Solution1103 : IRunProgram
    {
        public void Run()
        {
            DistributeCandies(7, 4).Print();
        }
        public int[] DistributeCandies(int candies, int num_people)
        {
            if (num_people == 1) return [candies];

            int[] output = new int[num_people];
            int index = 0, candy_to_give = 1;

            while (candies > 0)
            {
                if (candies < candy_to_give)
                {
                    output[index] += candies;
                    candies = 0;
                }
                else
                {
                    output[index] += candy_to_give;
                    candies -= candy_to_give;
                    candy_to_give++;
                }
                index = (index + 1) % num_people;
            }

            return output;
        }
    }
}
