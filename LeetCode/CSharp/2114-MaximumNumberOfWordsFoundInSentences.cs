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
    internal class Solution2114 : IRunProgram
    {
        public void Run()
        {
            MostWordsFound(
                ["alice and bob love leetcode", 
                "i think so too", 
                "this is great thanks very much"]
            ).Print();
        }

        public int MostWordsFound(string[] sentences)
        {
            int cnt = 0;
            for (int i = 0; i < sentences.Length; i++)
            {
                int m = sentences[i].Split().Length;
                if (m > cnt)
                {
                    cnt = m;
                }
            }
            return cnt;
        }
    }
}