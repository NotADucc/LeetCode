using LeetCode.Shared;

namespace LeetCode.CSharp;

internal class Solution0160 : IRunProgram
{
    public void Run()
    {
        
    }

    public ListNode GetIntersectionNode(ListNode headA, ListNode headB)
    {
        HashSet<ListNode> visited = new HashSet<ListNode>();
        while (headA is not null)
        {
            visited.Add(headA);
            headA = headA.next;
        }
        while (headB is not null)
        {
            if (visited.Contains(headB))
            {
                return headB;
            }
            headB = headB.next;
        }
        return null;
    }
}
