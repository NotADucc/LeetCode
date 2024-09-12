using LeetCode.Shared;

namespace LeetCode.CSharp
{
    internal class Solution0443 : IRunProgram
    {
        public void Run()
        {
            Compress(['a', 'a', 'b', 'b', 'c', 'c', 'c']).Print();
            Compress(['a']).Print();
        }
        public int Compress(char[] chars)
        {
            int w1 = 0, w2 = 1, chIndex = 0;

            while (w1 < chars.Length)
            {
                if (w1 + w2 < chars.Length && chars[w1] == chars[w1 + w2])
                {
                    w2++;
                    continue;
                }
                else
                {
                    chIndex += WriteNums(chars, chIndex, w2);

                    if (w1 + w2 < chars.Length)
                    {
                        chars[chIndex] = chars[w2 + w1];
                    }

                    w1 += w2;
                    w2 = 1;
                }
            }

            return chIndex;
        }

        int WriteNums(char[] chars, int chIndex, int w2)
        {
            if (w2 == 1)
            {
                return 1;
            }
            int output = 1;
            const int ASCII_ZERO = 48;

            Stack<char> stack = new Stack<char>();
            while (w2 > 0)
            {
                int temp = w2 % 10;

                stack.Push((char)(temp + ASCII_ZERO));

                w2 = w2 / 10;
            }

            while (stack.Count > 0)
            {
                char val = stack.Pop();
                chars[chIndex + output] = val;
                output++;
            }

            return output;
        }
    }
}
