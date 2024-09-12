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
    internal class Solution2418 : IRunProgram
    {
        public void Run()
        {
            SortPeople(["Mary", "John", "Emma"], [180, 165, 170]).Print();
        }
        public string[] SortPeople(string[] names, int[] heights)
        {
            int i = 0;
            Dictionary<int, int> dctHeights = heights.ToDictionary(x => x, _ => i++);
            Array.Sort(heights);

            var output = new string[names.Length];
            for (i = 0; i < heights.Length; i++)
            {
                output[i] = names[dctHeights[heights[^(i + 1)]]];
            }
            return output;
        }
    }
}
