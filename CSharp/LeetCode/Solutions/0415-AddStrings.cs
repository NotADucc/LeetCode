using LeetCode.Shared;

namespace LeetCode.CSharp;

internal class Solution0415 : IRunProgram
{
    public void Run()
    {
        AddStrings("11", "123").Print();
        AddStrings("0", "0").Print();
    }
    private const int _ASCII_CHAR_0 = 48;
    public string AddStrings(string num1, string num2)
    {
        Stack<char> stack = new Stack<char>();
        string longerString = "";
        string shorterString = "";

        if (num1.Length < num2.Length)
        {
            shorterString = num1;
            longerString = num2;
        }
        else
        {
            shorterString = num2;
            longerString = num1;
        }
        int carry = 0;
        for (int i = 1; i < shorterString.Length + 1; i++)
        {
            int g1 = shorterString[^i] - _ASCII_CHAR_0;
            int g2 = longerString[^i] - _ASCII_CHAR_0;
            int combined = g1 + g2 + carry;
            carry = combined / 10;
            combined = combined % 10;
            stack.Push((char)(combined + _ASCII_CHAR_0));
        }

        for (int i = shorterString.Length + 1; i < longerString.Length + 1; i++)
        {
            int g1 = longerString[^i] - _ASCII_CHAR_0;
            int combined = g1 + carry;
            carry = combined / 10;
            combined = combined % 10;
            stack.Push((char)(combined + _ASCII_CHAR_0));
        }

        if (carry > 0)
        {
            stack.Push((char)(1 + _ASCII_CHAR_0));
        }

        return string.Join("", stack);
    }
}
