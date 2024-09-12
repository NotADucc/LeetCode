using LeetCode.Shared;

namespace LeetCode.CSharp
{
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
            var slow = head;
            var fast = head;
            int len = 0;
            for (int i = 0; i < n; i++)
            {
                fast = fast.next;
                len++;
            }

            var prev = head;
            while (fast is not null)
            {
                prev = slow;
                slow = slow.next;
                fast = fast.next;
                len++;
            }

            if (len == 1) { return null; }

            if (slow.next is not null)
            {
                slow.val = slow.next.val;
                slow.next = slow.next.next;
            }
            else
            {
                slow.val = prev.val;
                prev.next = prev.next.next;
            }

            return head;
        }
    }
}
