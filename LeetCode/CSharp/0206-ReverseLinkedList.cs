using LeetCode.Shared;

namespace LeetCode.CSharp
{
    internal class Solution0206 : IRunProgram
    {
        public void Run()
        {
            ReverseList(ListNodeHelper.New(10)).Print();
        }
        public ListNode ReverseList(ListNode head)
        {
            ListNode node = null;
            Helper(head, ref node);
            return node;
        }

        private void Helper(ListNode head, ref ListNode node)
        {
            if (head is null) { return; }

            node = new ListNode(head.val, node);
            head = head.next;
            Helper(head, ref node);
        }
    }
}
