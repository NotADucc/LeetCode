﻿using LeetCode.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.CSharp
{
    internal class Solution1773 : IRunProgram
    {
        public void Run()
        {
            CountMatches([["phone", "blue", "pixel"], ["computer", "silver", "lenovo"], ["phone", "gold", "iphone"]], "color", "silver").Print();
        }

        public int CountMatches(IList<IList<string>> items, string ruleKey, string ruleValue)
        {
            var keyIndex = TranslateKey(ruleKey);
            int output = 0;

            foreach (var item in items)
            {
                if (item[keyIndex].Equals(ruleValue))
                {
                    output++;
                }
            }

            return output;
        }
        private int TranslateKey(string key) => key switch
        {
            "type" => 0,
            "color" => 1,
            "name" => 2,
        };
    }
}