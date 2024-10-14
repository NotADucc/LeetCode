/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     int val;
 *     ListNode next;
 *     ListNode() {}
 *     ListNode(int val) { this.val = val; }
 *     ListNode(int val, ListNode next) { this.val = val; this.next = next; }
 * }
 */
class Solution {
    public ListNode sortList(ListNode head) {
        if (head == null || head.next == null) 
            return head;

        ListNode middle = getMiddle(head);
        ListNode left = head;
        ListNode right = middle.next;
        middle.next = null;

        return merge(sortList(left), sortList(right));
    }
    private ListNode getMiddle(ListNode head) {
        ListNode slow = head;
        ListNode fast = head.next;
        while (fast != null && fast.next != null) {
            slow = slow.next;
            fast = fast.next.next;
        }
        return slow;
    }
    private ListNode merge(ListNode left, ListNode right)
    {
        var head = new ListNode();
        var tail = head;
        while (left != null && right != null) {
            if (left.val < right.val) {
                tail.next = left;
                left = left.next;
            }
            else {
                tail.next = right;
                right = right.next;
            }
            tail = tail.next;
        }

        tail.next = left != null ? left : right;

        return head.next;
    }
}