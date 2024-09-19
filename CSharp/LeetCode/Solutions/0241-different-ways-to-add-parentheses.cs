using LeetCode.Solutions.Shared;

namespace LeetCode.Solutions;

internal class Solution0241 : IRunProgram
{
    public void Run()
    {
        DiffWaysToCompute("2-1-1").Print();
        DiffWaysToCompute("2*3-4*5").Print();
    }

    public IList<int> DiffWaysToCompute(string expression)
    {
        IList<int> output = new List<int>();

        for (int i = 0; i < expression.Length; i++)
        {
            if (!char.IsDigit(expression[i]))
            {
                var l = DiffWaysToCompute(expression[..i]);
                var r = DiffWaysToCompute(expression[(i + 1)..]);

                foreach (int l1 in l)
                {
                    foreach (int r1 in r)
                    {
                        output.Add(Calc(l1, expression[i], r1));
                    }
                }
            }
        }

        return output.Count == 0 ? [int.Parse(expression)] : output;
    }

    private int Calc(int current, char sign, int num) => sign switch
    {
        '+' => current + num,
        '-' => current - num,
        '*' => current * num,
    };
}
