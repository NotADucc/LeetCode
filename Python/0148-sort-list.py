# Definition for singly-linked list.
# class ListNode:
#     def __init__(self, val=0, next=None):
#         self.val = val
#         self.next = next
class Solution:
    def sortList(self, head: Optional[ListNode]) -> Optional[ListNode]:
        if head is None or head.next is None :
            return head 

        middle = self.get_middle(head)
        left = head
        right = middle.next
        middle.next = None
        return self.merge(self.sortList(left), self.sortList(right))

    def get_middle(self, head) :
        slow = head
        fast = head.next
        while fast and fast.next:
            slow = slow.next
            fast = fast.next.next

        return slow

    def merge(self, left, right) :
        head = ListNode()
        curr = head
        while left and right :
            if left.val <= right.val :
                curr.next = left
                left = left.next
            else : 
                curr.next = right
                right = right.next
            curr = curr.next
        if left :
            curr.next = left
        else : 
            curr.next = right
        return head.next