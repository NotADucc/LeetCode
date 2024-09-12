using LeetCode.Shared;

namespace LeetCode.CSharp
{
    internal class Solution2375 : IRunProgram
    {
        public void Run()
        {
            SmallestNumber("IIIDIDDD").Print();
        }
        public string SmallestNumber(string pattern)
        {
            Stack<char> stack = new Stack<char>();
            int ToDig(char ch) => ch - '0';
            char ToChar(int dig) => (char)(dig + '0');


            stack.Push(ToChar(1));
            int d_index = 0;
            for (int i = 0; i < pattern.Length; i++)
            {
                if (pattern[i] == 'I')
                {
                    int plus = i - d_index + 1;
                    stack.Push(ToChar(ToDig(stack.Peek()) + plus));
                    d_index = i + 1;
                }
                else
                {
                    Stack<char> temp_stack = new Stack<char>();
                    while (stack.Count - 1 > d_index)
                    {
                        temp_stack.Push(stack.Pop());
                    }
                    char temp = stack.Pop();
                    stack.Push(ToChar(ToDig(temp) + 1));
                    stack.Push(ToChar(ToDig(temp)));
                    while (temp_stack.Count > 0)
                    {
                        stack.Push(temp_stack.Pop());
                    }
                }
            }

            return string.Join("", stack.Reverse());
        }
    }
}
