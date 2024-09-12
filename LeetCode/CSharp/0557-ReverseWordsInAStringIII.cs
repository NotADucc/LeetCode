using LeetCode.Shared;

namespace LeetCode.CSharp
{
    internal class Solution0557 : IRunProgram
    {
        public void Run()
        {
            ReverseWords("Let's take LeetCode contest").Print();
        }
        public string ReverseWords(string s)
        {
            var span = s.AsSpan();
            int lengthWord = 0;

            Span<char> output = stackalloc char[span.Length];

            for (int i = 0; i < span.Length; i += lengthWord)
            {
                var index = span.Slice(i).IndexOf(' ');

                if (index == 0)
                {
                    output[i] = ' ';
                    lengthWord = 1;
                    continue;
                }

                lengthWord = index == -1 ? span.Length - i : index;

                int left = i;
                int right = left + lengthWord - 1;

                while (left < right)
                {
                    output[left] = span[right];
                    output[right] = span[left];

                    left++;
                    right--;
                }
                if (left == right)
                {
                    output[left] = span[left];
                }
            }

            return output.ToString();
        }
    }
}
