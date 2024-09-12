using LeetCode.Shared;

namespace LeetCode.CSharp;

internal class Solution0876: IRunProgram
{
    public void Run()
    {
        MiddleNode(ListNodeHelper.New(10)).Print();
    }
    public ListNode MiddleNode(ListNode head)
    {
        var slow = head;
        var fast = head.next;

        while (fast is not null)
        {
            slow = slow.next;
            fast = fast.next?.next;
        }

        return slow;
    }
}
