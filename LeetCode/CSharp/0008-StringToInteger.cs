using LeetCode.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.CSharp
{
    internal class Solution0008 : IRunProgram
    {
        public void Run()
        {
            MyAtoi("42").Print();
            MyAtoi("-042").Print();
        }
        public int MyAtoi(string s)
        {
            int current = 0;

            (int i, int sign) = RemovePrefix(s);

            for (; i < s.Length; i++)
            {
                char ch = s[i];

                if (ch < '0' || ch > '9')
                {
                    return current * sign;
                }

                long temp = (long)(current) * 10 + (ch - 48);
                if (sign == 1 && temp >= int.MaxValue)
                {
                    return int.MaxValue;
                }
                else if (sign == -1 && temp >= ((long)(int.MaxValue) + 1))
                {
                    return int.MinValue;
                }
                current = (int)temp;
            }

            return current * sign;
        }

        private (int, int) RemovePrefix(string s)
        {
            int i = 0;
            while (i < s.Length)
            {
                char ch = s[i];
                if (ch == ' ')
                {
                    i++;
                    continue;
                }
                else if (ch == '-')
                {
                    return (i + 1, -1);
                }
                else if (ch == '+')
                {
                    return (i + 1, 1);
                }
                else if (ch == '0')
                {
                    return (i + 1, 1);
                }
                else
                {
                    return (i, 1);
                }
            }
            return (0, 1);
        }
    }
}
