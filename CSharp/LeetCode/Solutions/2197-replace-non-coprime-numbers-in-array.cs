using LeetCode.Solutions.Shared;
using Microsoft.Diagnostics.Tracing.Parsers.ClrPrivate;
using System.Runtime.InteropServices;

namespace LeetCode.Solutions;
internal class Solution2197 : IRunProgram
{
    public void Run()
    {
        ReplaceNonCoprimes([6, 4, 3, 2, 7, 6, 2]).Print();
        ReplaceNonCoprimes([2, 2, 1, 1, 3, 3, 3]).Print();
        ReplaceNonCoprimes([31, 97561, 97561, 97561, 97561, 97561, 97561, 97561, 97561]).Print();
    }

    public IList<int> ReplaceNonCoprimes(int[] nums)
    {
        Stack<int> stack = new Stack<int>(nums);
        Stack<int> res = new Stack<int>();

        while (stack.Count > 0)
        {
            if (stack.Count == 1)
            { 
                res.Push(stack.Pop());
                break;
            }

            int a = stack.Pop();
            int b = stack.Pop();

            int gcd = (int)get_gcd(a, b);
            if (gcd > 1)
            {
                stack.Push((int)get_lcm(a, b));
                if (res.Count > 0)
                    stack.Push(res.Pop());
            }
            else
            {
                stack.Push(b);
                res.Push(a);
            }
        }

        return res.ToList();
    }
    private static long get_lcm(long a, long b) => Math.Abs(a* b) / get_gcd(a, b);
    private static long get_gcd(long a, long b)
    {
        if (a == 0) return b;
        return get_gcd(b % a, a);
    }
}
