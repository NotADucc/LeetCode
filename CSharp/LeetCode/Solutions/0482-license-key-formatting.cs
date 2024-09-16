using LeetCode.Solutions.Shared;
using System.Text;

namespace LeetCode.Solutions;

internal class Solution0482 : IRunProgram
{
    public void Run()
    {
        LicenseKeyFormatting("5F3Z-2e-9-w", 3).Print();
        LicenseKeyFormatting("5F3Z-2e-9-w", 4).Print();
        LicenseKeyFormatting("2-5g-3-J", 2).Print();
        LicenseKeyFormatting("2", 1).Print();
        LicenseKeyFormatting("--aa--aa--", 1).Print();
        LicenseKeyFormatting("-----", 1).Print();
    }

    public string LicenseKeyFormatting(string s, int k)
    {
        StringBuilder sb = new StringBuilder();
        for (int i = s.Length - 1; i >= 0; i -= k)
        {
            int max_index = Math.Max(i - k + 1, 0);

            for (int j = i; j >= max_index; j--)
            {
                if (s[j] == '-')
                {
                    i--;
                    max_index = Math.Max(max_index - 1, 0);
                    continue;
                }
                sb.Insert(0, char.ToUpper(s[j]));
            }

            sb.Insert(0, '-');
        }

        while (sb.Length > 0 && sb[0] == '-') sb.Remove(0, 1);

        return sb.ToString();
    }
}
