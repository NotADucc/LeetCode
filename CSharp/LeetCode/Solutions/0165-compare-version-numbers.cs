using LeetCode.Solutions.Shared;

namespace LeetCode.Solutions;
internal class Solution0165 : IRunProgram
{
    public void Run()
    {

    }

    public int CompareVersion(string version1, string version2)
    {
        for (int v1_idx = 0, v2_idx = 0; 
            v1_idx < version1.Length || v2_idx < version2.Length; 
            v1_idx++, v2_idx++)
        {
            (int num1, v1_idx) = get_num(version1, v1_idx);
            (int num2, v2_idx) = get_num(version2, v2_idx);

            if (num1 < num2)
                return -1;
            else if (num1 > num2)
                return 1;
        }

        return 0;
    }

    private static (int res, int new_idx) get_num(string version, int start_idx)
    {
        int res = 0;
        while (start_idx < version.Length && version[start_idx] != '.')
        {
            res *= 10;
            res += version[start_idx] - '0';
            start_idx++;
        }
        return (res, start_idx);
    }
}
