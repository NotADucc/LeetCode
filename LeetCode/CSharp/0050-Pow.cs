using LeetCode.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.CSharp
{
    public class Solution0050 : IRunProgram
    {
        public void Run()
        {
            MyPow(2.0, 10).Print();
            MyPow(4.0, 10).Print();
            MyPow(1.0, 10).Print();
            MyPow(-1.0, 10).Print();
            MyPow(-1.0, 1).Print();
            MyPow(-1.0, -1).Print();
        }

        public double MyPow(double x, int n)
        {
            if (x == 1 || x == -1) { return (n & 1) == 0 ? 1 : x; }
            else if (n == int.MinValue) { return 0; }
            double output = 1.0;
            int new_n = n < 0 ? -n : n;
            for (int i = 0; i < new_n; i++)
            {
                output *= x;
            }
            return n < 0 ? 1 / output : output;
        }
    }
}
