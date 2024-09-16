using LeetCode.Solutions.Shared;

namespace LeetCode.Solutions.Shared;

public class ListNode
{
    public int val;
    public ListNode next;
    public ListNode(int val = 0, ListNode next = null)
    {
        this.val = val;
        this.next = next;
    }
    public override string ToString()
    {
        return $"{val} -> {next}";
    }
}

public static class ListNodeHelper
{
public static ListNode? New(int total)
{
    if (total < 1)
    {
        return null;
    }
    ListNode node = new ListNode(1);
    var n = node;
    for (int i = 1; i < total; i++)
    {
        n.next = new ListNode(i + 1);
        n = n.next;
    }
    return node;
}
public static ListNode? New(int startValue, int endValue)
{
    (startValue, endValue) = startValue < endValue ? (startValue, endValue) : (endValue, startValue);
    ListNode node = new ListNode(startValue);
    var n = node;
    for (int i = startValue; i < endValue; i++)
    {
        n.next = new ListNode(i + 1);
        n = n.next;
    }
    return node;
}
}