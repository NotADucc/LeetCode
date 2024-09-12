using LeetCode.Shared;

namespace LeetCode.CSharp
{
    public class Solution0083 : IRunProgram
    {
        public void Run()
        {
            DeleteDuplicates(ListNodeHelper.New(10)).Print();
        }

        public ListNode DeleteDuplicates(ListNode head)
        {
            if (head is null || head.next is null)
            {
                return head;
            }


            if (head.val == head.next.val)
            {
                head.next = head.next.next;
                head = DeleteDuplicates(head);
            }

            head.next = DeleteDuplicates(head.next);

            return head;
        }
    }
}
