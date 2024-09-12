using LeetCode.Shared;

namespace LeetCode.CSharp
{
    internal class Solution0022: IRunProgram
    {
        public void Run()
        {
            GenerateParenthesis(3).Print();
            GenerateParenthesis(1).Print();
        }

        public IList<string> GenerateParenthesis(int n)
        {
            var output = new List<string>();
            Helper(output, stackalloc char[n << 1], n, n, n);
            return output;
        }

        private void Helper(List<string> output, Span<char> temp, int n, int n_open, int n_closed)
        {
            if (n_open == 0 && n_closed == 0)
            {
                output.Add(temp.ToString());
            }
            else
            {
                if (n_open > 0)
                {
                    temp[n - n_closed + n - n_open] = '(';
                    Helper(output, temp, n, n_open - 1, n_closed);
                }
                if (n_open < n_closed && n_closed > 0)
                {
                    temp[n - n_open + n - n_closed] = ')';
                    Helper(output, temp, n, n_open, n_closed - 1);
                }
            }
        }
    }
}
