using LeetCode.Solutions.Shared;

namespace LeetCode.Solutions;
internal class Solution1290 : IRunProgram
{
    public void Run()
    {

    }

    public int GetDecimalValue(ListNode head)
    {
        int res = 0, exp = 31;
        while (head is not null)
        {
            exp--;
            if (head.val == 1)
                res |= 1 << exp;

            head = head.next;
        }
        res >>= exp;
        return res;
    }
}
