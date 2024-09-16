using LeetCode.Shared;

namespace LeetCode.CSharp;

internal class Solution0234 : IRunProgram
{
    public void Run()
    {
        IsPalindrome(ListNodeHelper.New(4)).Print();
    }

    public bool IsPalindrome(ListNode head)
    {
        ListNode slow = head;
        ListNode fast = head;
        ListNode prev = null;

        while (fast is not null && fast.next is not null)
        {
            fast = fast.next.next;
            var temp = slow.next;
            slow.next = prev;
            prev = slow;
            slow = temp;
        }

        if (fast is not null) slow = slow.next;

        while (prev is not null)
        {
            if (slow.val != prev.val)
            {
                return false;
            }
            slow = slow.next;
            prev = prev.next;
        }

        return true;
    }
}
