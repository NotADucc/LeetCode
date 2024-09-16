using LeetCode.Shared;
using System.Data;

namespace LeetCode.CSharp;

internal class Solution0203: IRunProgram
{
    public void Run()
    {
        RemoveElements(ListNodeHelper.New(1), 1).Print();
        RemoveElements(ListNodeHelper.New(5), 1).Print();
        RemoveElements(ListNodeHelper.New(5), 5).Print();
    }

    public ListNode RemoveElements(ListNode head, int val)
    {
        ListNode dummy = new ListNode(0, head);
        ListNode current = dummy;

        while (current.next is not null)
        {
            if (current.next.val == val)
            {
                current.next = current.next.next;
            }
            else
            {
                current = current.next;
            }
        }
        return dummy.next;
    }
}
