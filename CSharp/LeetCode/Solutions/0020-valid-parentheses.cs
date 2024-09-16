using LeetCode.Shared;

namespace LeetCode.CSharp;

internal class Solution0020: IRunProgram
{
    public void Run()
    {
        IsValid("()").Print();
        IsValid("(]").Print();
        IsValid("([()()])").Print();
    }

    public bool IsValid(string s)
    {
        if (s.Length == 1 || (s.Length & 1) == 1)
        {
            return false;
        }
        Dictionary<char, char> dct = new Dictionary<char, char>()
        {
            ['('] = ')',
            ['{'] = '}',
            ['['] = ']',
        };
        // back when i didnt know a stack existed
        string buffer = "";
        for (int i = 0; i < s.Length - 1; i++)
        {
            if (string.IsNullOrWhiteSpace(buffer) && !dct.ContainsKey(s[i]))
            {
                return false;
            }
            if (dct.ContainsKey(s[i]))
            {
                buffer += s[i];
                continue;
            }
            if (dct[buffer[^1]] == s[i])
            {
                buffer = buffer[..^1];
                continue;
            }
            for (int j = 0; j < buffer.Length; j++)
            {
                if (dct[buffer[j]] != s[i + buffer.Length - 1 - j])
                {
                    return false;
                }
            }
            buffer = "";
        }
        if (!string.IsNullOrWhiteSpace(buffer) && buffer.Length == 1)
        {
            return dct[buffer[0]] == s[^1];
        }
        return false;
    }
}
