using LeetCode.Shared;

namespace LeetCode.CSharp
{
    internal class Solution1945 : IRunProgram
    {
        public void Run()
        {
            GetLucky("iiii", 1).Print();
        }
        public int GetLucky(string s, int k)
        {
            Span<char> span = stackalloc char[s.Length << 1];
            int len = 0;

            for (int i = 0; i < s.Length; i++)
            {
                int temp = (s[i] - 96);
                if (temp > 9)
                {
                    span[len] = (char)(temp / 10);
                    span[len + 1] = (char)(temp % 10);
                    len += 2;
                }
                else
                {
                    span[len] = (char)temp;
                    len++;
                }
            }

            int res = 0;
            for (int i = 0; i < k; i++)
            {
                res = 0;
                foreach (var ch in span.Slice(0, len))
                {
                    res += ch;
                }
                if (res < 10)
                {
                    return res;
                }
                else if (res < 100)
                {
                    len = 2;
                    span[0] = (char)(res / 10);
                    span[1] = (char)(res % 10);
                }
                else if (res < 1000)
                {
                    len = 3;
                    span[0] = (char)(res / 100);
                    span[1] = (char)(res % 100 / 10);
                    span[2] = (char)(res % 10);
                }
                else
                {
                    len = 4;
                    span[0] = (char)(res / 1000);
                    span[1] = (char)(res % 1000 / 100);
                    span[2] = (char)(res % 1000 % 100 / 10);
                    span[3] = (char)(res % 10);
                }
            }

            return res;
        }
    }
}
