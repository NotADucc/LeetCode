using LeetCode.Solutions.Shared;

namespace LeetCode.Solutions;

internal class Solution0237 : IRunProgram
{
    public void Run()
    {
        // kinda cumbersome to replicate
    }

    public void DeleteNode(ListNode node)
    {
        node.val = node.next.val;
        node.next = node.next.next;
    }
}
