using LeetCode.Shared;


namespace LeetCode.CSharp
{
    internal class Solution2807 : IRunProgram
    {
        public void Run()
        {
            InsertGreatestCommonDivisors(ListNodeHelper.New(15)).Print();
        }

        public ListNode InsertGreatestCommonDivisors(ListNode head)
        {
            Helper(head);
            return head;
        }

        private void Helper(ListNode head)
        {
            if (head.next is null) { return; }


            (int a, int b) = head.val < head.next.val ? (head.next.val, head.val) : (head.val, head.next.val);
            while (b != 0)
            {
                (a, b) = (b, a % b);
            }

            ListNode node = new ListNode(a, head.next);
            head.next = node;
            Helper(head.next.next);
        }
    }
}
