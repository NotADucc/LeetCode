using LeetCode.Solutions.Shared;

namespace LeetCode.Solutions;

internal class Solution2181 : IRunProgram
{
    public void Run()
    {
        
    }

    public ListNode MergeNodes(ListNode head)
    {
        var current = head;

        while (current.next is not null)
        {
            if (current.next.val == 0)
            {
                current = current.next;
            }
            else
            {
                current.val += current.next.val;
                current.next = current.next.next;
            }

            if (current.next.next is null)
            {
                current.next = null;
            }
        }

        return head;
    }
}
