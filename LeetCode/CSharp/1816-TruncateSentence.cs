using LeetCode.Shared;

namespace LeetCode.CSharp
{
    internal class Solution1816 : IRunProgram
    {
        public void Run()
        {
            TruncateSentence("Hello how are you Contestent", 1).Print();
        }

        public string TruncateSentence(string s, int k)
        {
            var span = s.AsSpan();
            int size = 0;
            k--;
            foreach (char ch in span)
            {
                if (ch == ' ')
                {
                    if (k <= 0)
                    {
                        break;
                    }
                    k--;
                }
                size++;
            }

            return span.Slice(0, size).ToString();
        }
    }
}
