using LeetCode.Shared;

namespace LeetCode.CSharp;

internal class Solution0278 : IRunProgram
{
    public void Run()
    {
        FirstBadVersion(2126753390).Print();
    }

    public int FirstBadVersion(int n)
    {
        int left = 1, right = n - 1;
        while (left <= right)
        {
            int mid = (int)(((long)left + right) >> 1);
            bool is_bad = IsBadVersion(mid);
            if (!is_bad)
            {
                left = mid + 1;
            }
            else 
            { 
                right = mid - 1;
            }
        }
        return left;
    }

    private bool IsBadVersion(int version) => version >= 1702766719;
}
