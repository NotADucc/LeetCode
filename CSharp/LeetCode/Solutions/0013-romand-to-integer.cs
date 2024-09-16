using LeetCode.Solutions.Shared;

namespace LeetCode.Solutions;

internal class Solution0013 : IRunProgram
{
    public void Run()
    {
        RomanToInt("III").Print();
        RomanToInt("V").Print();
        RomanToInt("X").Print();
    }

    public int RomanToInt(string s)
    {
        List<int> c = new List<int>();
        Dictionary<string, int> dct = new Dictionary<string, int>()
        {
            ["I"] = 1,
            ["V"] = 5,
            ["X"] = 10,
            ["L"] = 50,
            ["C"] = 100,
            ["D"] = 500,
            ["M"] = 1000
        };
        string buffer = "";
        for (int i = 0; i < s.Length; i++)
        {
            if (dct.ContainsKey(buffer))
            {
                if (dct[buffer] >= dct[s[i].ToString()])
                {
                    c.Add(dct[buffer]);
                    buffer = s[i].ToString();
                    continue;
                }
                c.Add(dct[s[i].ToString()] - dct[buffer]);
                buffer = "";
                continue;
            }
            buffer += s[i];
        }
        if (!String.IsNullOrWhiteSpace(buffer))
        {
            c.Add(dct[buffer]);
        }
        return c.Sum();
    }
}
