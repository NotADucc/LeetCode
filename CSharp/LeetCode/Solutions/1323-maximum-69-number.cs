using LeetCode.Solutions.Shared;

namespace LeetCode.Solutions;
internal class Solution1323 : IRunProgram
{
    public void Run()
    {
        Maximum69Number(9669).Print();
        Maximum69Number(9969).Print();
    }

    public int Maximum69Number(int num)
    {
        int temp = num;
        for (int idx = 5; idx >= 0; idx--)
        {
            int ten = (int)Math.Pow(10, idx);
            int res = temp / ten;
            if (res == 6)
            {
                return num + (ten * 3);
            }
            temp -= res * ten;
        }

        return num;
    }

    public int Maximum69NumberString(int num)
    {
        char[] res = num.ToString().ToArray();
        int n = res.Length;

        for (int i = 0; i < n; i++)
        {
            if (res[i] == '6')
            {
                res[i] = '9';
                break;
            }
        }

        return int.Parse(res);
    }
}
