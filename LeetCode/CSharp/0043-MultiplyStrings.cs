using LeetCode.Shared;
using System.Text;

namespace LeetCode.CSharp;

public class Solution0043 : IRunProgram
{
    public void Run()
    {
        Multiply("3", "1").Print();
        Multiply("3", "6").Print();
    }

    public string Multiply(string num1, string num2)
    {
        if (num1.Equals("0") || num2.Equals("0")) { return "0"; }
        int Parse(char val) => val - '0';

        var total = new StringBuilder();

        for (int i = num1.Length - 1; i >= 0; i--)
        {
            var temp = new StringBuilder();

            var num1_digit = Parse(num1[i]);
            int carry = 0;
            for (int j = num2.Length - 1; j >= 0; j--)
            {
                var num2_digit = Parse(num2[j]);

                int mul = (num1_digit * num2_digit) + carry;

                temp.Insert(0, mul % 10);
                carry = mul / 10;
            }

            if (carry > 0)
            {
                temp.Insert(0, carry);
                carry = 0;
            }


            for (int j = 0; j < num1.Length - 1 - i; j++)
            {
                temp.Append('0');
            }

            if (total.Length != 0)
            {
                (StringBuilder longest, StringBuilder shortest) = total.Length < temp.Length ? (temp, total) : (total, temp);
                temp = new StringBuilder();
                int k = shortest.Length - 1;
                for (int j = longest.Length - 1; j >= 0; j--, k--)
                {
                    if (k >= 0)
                    {
                        var long_digit = Parse(longest[j]);
                        var short_digit = Parse(shortest[k]);

                        int add = long_digit + short_digit + carry;

                        temp.Insert(0, add % 10);
                        carry = add / 10;
                    }
                    else
                    {
                        var long_digit = Parse(longest[j]);
                        long_digit = long_digit + carry;
                        temp.Insert(0, long_digit % 10);
                        carry = long_digit / 10;
                    }
                }
                if (carry > 0)
                {
                    temp.Insert(0, 1);
                }
            }
            total = temp;
        }

        return total.ToString();
    }
}
