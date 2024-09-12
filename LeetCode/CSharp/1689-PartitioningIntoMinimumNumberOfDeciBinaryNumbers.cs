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
    internal class Solution1689 : IRunProgram
    {
        public void Run()
        {
            MinPartitions("32").Print();
        }

        public int MinPartitions(string n)
        {
            return Convert.ToInt32(n.Max());
        }
    }
}
