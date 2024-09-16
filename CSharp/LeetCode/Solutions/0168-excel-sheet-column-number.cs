using LeetCode.Shared;
using System.Text;

namespace LeetCode.CSharp;

internal class Solution0168 : IRunProgram
{
    public void Run()
    {
        ConvertToTitle(1).Print();
        ConvertToTitle(28).Print();
        ConvertToTitle(70149123).Print();
    }


    private const int _ASCII_BASE = 64;

    public string ConvertToTitle(int columnNumber)
    {
        StringBuilder sb = new StringBuilder();

        while (columnNumber > 0)
        {
            int rest = columnNumber % 26;
            rest = rest == 0 ? 26 : rest;
            sb.Insert(0, (char)(rest + _ASCII_BASE));

            columnNumber -= rest;
            columnNumber /= 26;
        }

        return sb.ToString();
    }
}
