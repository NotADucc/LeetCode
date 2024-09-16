using LeetCode.Solutions.Shared;

namespace LeetCode.Solutions;

internal class Solution0021: IRunProgram
{
    public void Run()
    {
        MergeTwoLists(ListNodeHelper.New(2), ListNodeHelper.New(6)).Print();
    }

    public ListNode MergeTwoLists(ListNode list1, ListNode list2)
    {
        ListNode output = new ListNode();
        return GiveSmallerValue(output, list1, list2);
    }
    private ListNode GiveSmallerValue(ListNode baseList, ListNode l, ListNode r)
    {
        if (l is null)
        {
            return r;
        }
        if (r is null)
        {
            return l;
        }
        if (l.val <= r.val)
        {
            baseList.val = l.val;
            l = l.next;
        }
        else
        {
            baseList.val = r.val;
            r = r.next;
        }
        baseList.next = GiveSmallerValue(new ListNode(), l, r);
        return baseList;
    }
}
