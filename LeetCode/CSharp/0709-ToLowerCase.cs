using LeetCode.CSharp.Shared;
using LeetCode.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace LeetCode.CSharp
{
    internal class Solution0709: IRunProgram
    {
        public void Run()
        {
            ToLowerCase("AAAAA").Print();
        }
        public string ToLowerCase(string s)
        {
            return s.ToLower();
        }
    }
}
