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
    internal class Solution2469 : IRunProgram
    {
        public void Run()
        {
            ConvertTemperature(36.5).Print();
        }
        public double[] ConvertTemperature(double celsius)
        {
            return new double[] { celsius + 273.15, (celsius * 1.8 + 32) };
        }
    }
}