/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int val=0, ListNode next=null) {
 *         this.val = val;
 *         this.next = next;
 *     }
 * }
 */

public class Solution {
    public ListNode ReverseKGroup(ListNode head, int k) {

        if (head == null || k <= 1) return head;

        var slow = head;
        var fast = head;
        int c = k;
        while(c>0)
        {
        if (fast == null) return head;
        fast = fast.next;
        c--;
        }

        ListNode prev = null;
        var curr = slow;
        while(curr != fast)
        {
            var temp = curr.next;
            curr.next = prev;
            prev = curr;
            curr = temp;
        }
        slow.next = ReverseKGroup(fast,k);
        return prev;
        
    }
}
