using LeetCode.Shared;

namespace LeetCode.CSharp
{
    internal class Solution1963 : IRunProgram
    {
        public void Run()
        {
            MinSwaps("][][").Print();
            MinSwaps("]]][[[").Print();
        }
        public unsafe int MinSwaps(string s)
        {
            Span<char> sSpan;
            fixed (char* ptr = s)
            {
                sSpan = new Span<char>(ptr, s.Length);
            }

            int evenDelta = 0, left = 0, right = sSpan.Length - 1;
            int output = 0;
            while (left < right)
            {
                evenDelta = sSpan[left] == ']' ? evenDelta + 1 : evenDelta - 1;
                if (evenDelta > 0)
                {
                    output++;
                    while (left < right)
                    {
                        if (sSpan[right] == '[')
                        {
                            sSpan[right] = ']';
                            right--;
                            break;
                        }
                        right--;
                    }
                    evenDelta -= 2;
                }
                left++;
            }

            return output;
        }
    }
}
