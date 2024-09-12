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
    internal class Solution2391 : IRunProgram
    {
        public void Run()
        {
            GarbageCollection(["G", "P", "GP", "GG"], [2, 4, 3]).Print();
        }
        public int GarbageCollection(string[] garbage, int[] travel)
        {
            int output = 0;
            int potentialGlass = 0, potentialPaper = 0, potentialMetal = 0;
            for (int i = 0; i < garbage.Length; i++)
            {
                int travelCost = i == 0 ? 0 : travel[i - 1];

                int glassCount = CountAmount(garbage[i].AsSpan(), 'G');
                int paperCount = CountAmount(garbage[i].AsSpan(), 'P');
                int metalCount = CountAmount(garbage[i].AsSpan(), 'M');

                output += glassCount + paperCount + metalCount;

                potentialGlass += travelCost;
                potentialPaper += travelCost;
                potentialMetal += travelCost;

                if (glassCount != 0)
                {
                    output += potentialGlass;
                    potentialGlass = 0;
                }
                if (paperCount != 0)
                {
                    output += potentialPaper;
                    potentialPaper = 0;
                }
                if (metalCount != 0)
                {
                    output += potentialMetal;
                    potentialMetal = 0;
                }
            }

            return output;
        }

        private int CountAmount(ReadOnlySpan<char> s, char ch)
        {
            int output = 0;

            foreach (var sCh in s)
            {
                if (sCh.Equals(ch))
                {
                    output++;
                }
            }

            return output;
        }
    }
}
