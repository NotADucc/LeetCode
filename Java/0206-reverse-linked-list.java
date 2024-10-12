class Solution {
    public ListNode reverseList(ListNode head) {
        var current = head;
        ListNode prev = null;
        while (current != null) {
            var temp = current.next;
            current.next = prev;
            prev = current;
            current = temp;
        }
        return prev;
    }
}