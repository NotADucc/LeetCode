using LeetCode.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode._2Medium
{
    /*
    temp
    Runtime: 266ms 5.70%
    Memory: 63.8MB 12.43% 
    
    2 arr
    Runtime: 256ms 15.90%
    Memory: 60.5MB 48.51%
     */
    internal class OriginalArrayPrefixXOR : IRunProgram
    {
        private record Input(int[] Data, int[] Result);
        public void Run()
        {
            Input[] inputs = new Input[]
            {
                new Input(new int[]{ 5, 2, 0, 3, 1 }, new int[]{ 5, 7, 2, 3, 2 })
                ,
            };

            foreach (var input in inputs)
            {
                FindArray2Arr(input.Data).Print();
                input.Result.Print();
                Console.WriteLine();
            }
        }
        public int[] FindArray(int[] pref)
        {
            int temp = pref[0];
            for (int i = 1; i < pref.Length; i++)
            {
                int t = pref[i];
                pref[i] = temp ^ pref[i];
                temp = t;
            }
            return pref;
        }
        public int[] FindArray2Arr(int[] pref)
        {
            int[] output = new int[pref.Length];
            output[0] = pref[0];
            for (int i = 1; i < pref.Length; i++)
            {
                output[i] = pref[i - 1] ^ pref[i];
            }
            return output;
        }
    }
}
