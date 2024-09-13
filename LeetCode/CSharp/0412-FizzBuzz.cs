using LeetCode.Shared;
using System.Text;

namespace LeetCode.CSharp;

internal class Solution0412 : IRunProgram
{
    public void Run()
    {
        FizzBuzz(3).Print();
    }

    public IList<string> FizzBuzz(int n)
    {
        var output = new List<string>();
        StringBuilder sb = new StringBuilder();
        for (int i = 1; i <= n; i++)
        {
            if (i % 3 == 0)
            {
                sb.Append("Fizz");
            }
            if (i % 5 == 0)
            {
                sb.Append("Buzz");
            }
            output.Add(sb.Length == 0 ? i.ToString() : sb.ToString());
            sb.Clear();
        }
        return output;
    }
}
