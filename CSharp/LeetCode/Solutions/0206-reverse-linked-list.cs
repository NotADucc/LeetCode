using LeetCode.Solutions.Shared;

namespace LeetCode.Solutions;

internal class Solution0206 : IRunProgram
{
    public void Run()
    {
        ReverseListIte(ListNodeHelper.New(10)).Print();
        ReverseListRec(ListNodeHelper.New(10)).Print();
    }

    public ListNode ReverseListIte(ListNode head)
    {
        ListNode curr = head;
        ListNode prev = null;

        while (curr is not null)
        {
            var temp = curr.next;
            curr.next = prev;
            prev = curr;
            curr = temp;
        }

        return prev;
    }

    public ListNode ReverseListRec(ListNode head)
    {
        ListNode node = null;
        Helper(head, ref node);
        return node;
    }

    private void Helper(ListNode head, ref ListNode node) 
    {
        if (head is null) { return; }
        node = new ListNode(head.val, node);
        Helper(head.next, ref node);
    }
}
