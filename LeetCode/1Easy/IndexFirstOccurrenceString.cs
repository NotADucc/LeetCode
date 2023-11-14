using LeetCode.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode._1Easy
{
    /*
    Cheese
    Runtime: 49ms 94.65%
    Memory: 37.1MB 16.88%

    Normal
    Runtime: 66ms 14.27%
    Memory: 36.52MB 74.21%
    */
    public class IndexFirstOccurrenceString : IRunProgram
    {
        private record Input(string HayStack, string Needle);
        public void Run()
        {
            Input[] inputs = new Input[] 
            {
                //0
                new Input("sadbutsad", "sad")
                //-1
                ,new Input("leetcode", "leeto")
                //0
                ,new Input("a", "a")
            };

            foreach (var input in inputs)
            {
                Console.WriteLine(StrStr2(input.HayStack, input.Needle));
            }
        }

        public static int StrStr(string haystack, string needle)
        {
            //cheese
            return haystack.IndexOf(needle);
        }

        public static int StrStr2(string haystack, string needle)
        {
            for (int i = 0; i < haystack.Length; i++)
            {
                if (i + needle.Length > haystack.Length)
                {
                    break;
                }

                for (int j = 0; j < needle.Length; j++)
                {
                    if (haystack[i + j] != needle[j]) 
                    {
                        break;
                    }
                    if (j == needle.Length - 1)
                    {
                        return i;
                    }
                }
            }

            return -1;
        }
    }
}
