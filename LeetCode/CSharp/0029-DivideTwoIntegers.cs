using LeetCode.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.CSharp
{
    public class Solution0029 : IRunProgram
    {
        public void Run()
        {
            Divide(10, 3).Print();
            Divide(10, 2).Print();
        }

        public int Divide(int dividend, int divisor)
        {
            if (dividend == -2147483648 && divisor == -1) { return int.MaxValue; }

            bool neg = divisor < 0 ^ dividend < 0;

            long dividend_temp = Math.Abs((long)dividend);
            if (divisor == 1 || divisor == -1) { return neg ? ~((int)dividend_temp - 1) : (int)dividend_temp; }

            int output = 0;

            long divisor_temp = Math.Abs((long)divisor);

            while (dividend_temp >= divisor_temp)
            {
                output++;
                dividend_temp -= divisor_temp;
            }

            return neg ? ~(output - 1) : output;
        }
    }
}
