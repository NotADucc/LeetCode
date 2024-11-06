using LeetCode.Solutions.Shared;

namespace LeetCode.Solutions;

internal class Solution0023 : IRunProgram
{
    public void Run()
    {

    }

    public ListNode MergeKLists(ListNode[] lists) 
    {
        var q = new PriorityQueue<ListNode, int>();
        for (int i = 0; i < lists.Length; i++)
        {
            if (lists[i] is not null)
                q.Enqueue(lists[i], lists[i].val);
        }
        ListNode anchor = new ListNode(-1);
        ListNode curr = anchor;

        while (q.Count > 0)
        {
            ListNode deq = q.Dequeue();
            curr.next = deq;
            if (q.Count == 0)
            {
                break;
            }
            else
            {
                if (deq.next is not null) 
						q.Enqueue(deq.next, deq.next.val);
                curr = curr.next;
            }
        }

        return anchor.next;
    }
}
