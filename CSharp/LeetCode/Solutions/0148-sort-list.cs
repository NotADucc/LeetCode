using LeetCode.Solutions.Shared;

namespace LeetCode.Solutions;

internal class Solution0148 : IRunProgram
{
    public void Run()
    {
        
    }
    public ListNode SortList(ListNode head)
    {
        if (head is null || head.next is null) return head;
        (ListNode l, ListNode r) = Split(head);
        return Merge(SortList(l), SortList(r));
    }
    private (ListNode, ListNode) Split(ListNode head)
    {
        ListNode slowwer = head;
        ListNode slow = head;
        ListNode fast = head;
        while (fast is not null && fast.next is not null)
        {
            if (fast.next.next is not null) slowwer = slowwer.next;
            slow = slow.next;
            fast = fast.next.next;
        }
        if (fast is not null) slow = slow.next;
        slowwer.next = null;
        return (head, slow);
    }
    private ListNode Merge(ListNode left, ListNode right)
    {
        var head = new ListNode();
        var curr = head;
        while (left is not null && right is not null)
        {
            if (left.val < right.val)
            {
                var temp = left.next;
                left.next = null;
                curr.next = left;
                left = temp;
            }
            else
            {
                var temp = right.next;
                right.next = null;
                curr.next = right;
                right = temp;
            }
            curr = curr.next;
        }

        while (left is not null)
        {
            var temp = left.next;
            left.next = null;
            curr.next = left;
            left = temp;
            curr = curr.next;
        }

        while (right is not null)
        {
            var temp = right.next;
            right.next = null;
            curr.next = right;
            right = temp;
            curr = curr.next;
        }

        return head.next;
    }
}
