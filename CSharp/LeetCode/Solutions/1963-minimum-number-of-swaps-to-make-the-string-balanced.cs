using LeetCode.Solutions.Shared;

namespace LeetCode.Solutions;

internal class Solution1963 : IRunProgram
{
    public void Run()
    {
        MinSwaps("][][").Print();
        MinSwaps("]]][[[").Print();
    }
    public int MinSwaps(string s)
    {
        int count = 0, output = 0;

        for (int i = 0; i < s.Length; i++)
        {
            char ch = s[i];
            if (ch == '[')
            {
                count++;
            }
            else
            {
                if (count <= 0)
                {
                    count++;
                    output++;
                }
                else
                {
                    count--;
                }
            }
        }

        return output;
    }
}
