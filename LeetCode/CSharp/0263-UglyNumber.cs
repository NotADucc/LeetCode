using LeetCode.Shared;

namespace LeetCode.CSharp
{
    internal class Solution0263 : IRunProgram
    {
        public void Run()
        {
            IsUgly(6).Print();
            IsUgly(1).Print();
            IsUgly(14).Print();
        }

        public bool IsUgly(int n)
        {
            while (n > 0)
            {
                if (n == 1)
                {
                    return true;
                }

                if (n % 2 == 0)
                {
                    n /= 2;
                }
                else if (n % 3 == 0)
                {
                    n /= 3;
                }
                else if (n % 5 == 0)
                {
                    n /= 5;
                }
                else
                {
                    return false;
                }
            }
            return false;
        }
    }
}
