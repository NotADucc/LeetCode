﻿using LeetCode.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.CSharp
{
    internal class Solution0401 : IRunProgram
    {
        public void Run()
        {
            ReadBinaryWatch(1).Print();
            ReadBinaryWatch(2).Print();
            ReadBinaryWatch(3).Print();
            ReadBinaryWatch(4).Print();
            ReadBinaryWatch(5).Print();
        }

        public IList<string> ReadBinaryWatch(int turnedOn)
        {
            var output = new HashSet<string>();
            Helper(output, turnedOn, 0, 0, 8, 32);
            return output.ToList();
        }

        private void Helper(HashSet<string> output, int turned_on, int hour, int min, int hour_arr, int min_arr)
        {
            if (hour >= 12 || min >= 60)
            {
                return;
            }

            if (turned_on == 0)
            {
                string string_min = min.ToString();

                string prefix_min = new string('0', 2 - string_min.Length);

                output.Add($"{hour}:{prefix_min}{string_min}");
            }
            else
            {
                int temp = hour_arr;
                while (hour_arr > 0)
                {
                    Helper(output, turned_on - 1, hour + hour_arr, min, hour_arr >> 1, min_arr);
                    hour_arr >>= 1;
                }
                hour_arr = temp;
                while (min_arr > 0)
                {
                    Helper(output, turned_on - 1, hour, min + min_arr, hour_arr, min_arr >> 1);
                    min_arr >>= 1;
                }
            }
        }
    }
}