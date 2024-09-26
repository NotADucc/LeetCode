using LeetCode.Solutions.Shared;

namespace LeetCode.Solutions;

internal class Solution0067 : IRunProgram
{
    public void Run()
    {
        AddBinary("11", "1").Print();
    }

    public string AddBinary(string a, string b)
    {
        (string bString, string sString) = a.Length > b.Length ? (a, b) : (b, a);
        string temp = "";
        bool carryOver = false;
        for (int i = 0; i < bString.Length; i++)
        {
            if (sString.Length <= i && !carryOver)
            {
                temp = bString[^(i + 1)] + temp;
                continue;
            }
            if (sString.Length <= i && carryOver)
            {
                carryOver = false;
                if (bString[^(i + 1)] == '1')
                {
                    carryOver = true;
                    temp = "0" + temp;
                }
                else
                {
                    temp = "1" + temp;
                }
                continue;
            }
            if (!carryOver && sString[^(i + 1)] == '1' && bString[^(i + 1)] == '1')
            {
                carryOver = true;
                temp = "0" + temp;
                continue;
            }
            if (carryOver && sString[^(i + 1)] == '1' && bString[^(i + 1)] == '1')
            {
                carryOver = true;
                temp = "1" + temp;
                continue;
            }
            if (carryOver && (sString[^(i + 1)] == '1' || bString[^(i + 1)] == '1'))
            {
                carryOver = true;
                temp = "0" + temp;
                continue;
            }
            if (carryOver)
            {
                carryOver = false;
                temp = "1" + temp;
                continue;
            }
            if (sString[^(i + 1)] == '1')
            {
                temp = sString[^(i + 1)] + temp;
            }
            else
            {
                temp = bString[^(i + 1)] + temp;
            }
        }
        if (carryOver)
        {
            temp = "1" + temp;
        }
        return temp;
    }
}
