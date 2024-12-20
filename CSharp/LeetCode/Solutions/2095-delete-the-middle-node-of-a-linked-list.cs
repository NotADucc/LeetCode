﻿using LeetCode.Solutions.Shared;

namespace LeetCode.Solutions;

internal class Solution2095 : IRunProgram
{
    public void Run()
    {
        DeleteMiddle(ListNodeHelper.New(10)).Print();
    }

    public ListNode DeleteMiddle(ListNode head)
    {
        if (head.next is null)
        {
            return null;
        }
        var cope_slow = head;
        var slow = head;
        var fast = head;

        while (fast is not null && fast.next is not null)
        {
            cope_slow = slow;
            slow = slow.next;
            fast = fast.next.next;
        }

        cope_slow.next = slow.next;

        return head;
    }
}
