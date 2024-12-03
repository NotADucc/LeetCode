using LeetCode.Solutions.Shared;

namespace LeetCode.Solutions;

internal class Solution0019 : IRunProgram
{
    public void Run()
    {
        RemoveNthFromEnd(ListNodeHelper.New(10), 2).Print();
        RemoveNthFromEnd(ListNodeHelper.New(1), 2).Print();
        RemoveNthFromEnd(ListNodeHelper.New(2), 2).Print();
    }

    public ListNode RemoveNthFromEnd(ListNode head, int n)
    {
        ListNode dummy = new ListNode(0, head);
        ListNode left = dummy, right = head;

        while (n > 0)
        {
            right = right.next;
            n--;
        }

        while (right is not null)
        {
            left = left.next;
            right = right.next;
        }

        left.next = left.next.next;

        return dummy.next;
    }
}
