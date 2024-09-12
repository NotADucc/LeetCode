using LeetCode.Shared;
using System.Text;

namespace LeetCode.CSharp
{
    internal class Solution1678 : IRunProgram
    {
        public void Run()
        {
            Interpret("G()(al)").Print();
        }

        public string Interpret(string command)
        {
            var builder = new StringBuilder();

            int i = 0;
            while (i < command.Length)
            {
                if (command[i] == 'G')
                {
                    builder.Append("G");
                    i++;
                }
                else if (command[i] == '(' && command[i + 1] == ')')
                {
                    builder.Append("o");
                    i += 2;
                }
                else
                {
                    builder.Append("al");
                    i += 4;
                }
            }

            return builder.ToString();
        }
    }
}
