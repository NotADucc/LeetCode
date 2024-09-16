using LeetCode.Solutions.Shared;
using System.Text;

namespace LeetCode.Solutions;

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
    public IList<string> FizzBuzz_NoSB(int n)
    {
        var output = new List<string>();
        for (int i = 1; i <= n; i++)
        {
            int m3 = i % 3, m5 = i % 5;
            if (m3 == 0 && m5 == 0)
            {
                output.Add("FizzBuzz");
            }
            else if (m3 == 0)
            {
                output.Add("Fizz");
            }
            else if (m5 == 0)
            {
                output.Add("Buzz");
            }
            else
            {
                output.Add(i.ToString());
            }
        }
        return output;
    }
}
