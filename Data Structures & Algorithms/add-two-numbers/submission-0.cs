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
    public ListNode AddTwoNumbers(ListNode l1, ListNode l2) {
        ListNode prev1 = null;
        ListNode prev2 = null;
        var curr1 = l1;
        var curr2 = l2;
        while(curr1!=null)
        {
            var temp = curr1.next;
            curr1.next =prev1;
            prev1 = curr1;
            curr1 = temp;
        }
        while(curr2!=null)
        {
            var temp = curr2.next;
            curr2.next =prev2;
            prev2 = curr2;
            curr2 = temp;
        }
        string s1 = prev1.val.ToString();
        string s2 = prev2.val.ToString();

        while(prev1.next!=null)
        {
            s1 +=prev1.next.val.ToString();
            prev1=prev1.next;
        }

        while(prev2.next!=null)
        {
            s2 +=prev2.next.val.ToString();
            prev2=prev2.next;
        }

        int sum = int.Parse(s1) + int.Parse(s2);
        string s = sum.ToString();
        ListNode dummy = new ListNode(0);
        var newnode = dummy.next = new ListNode(int.Parse(s[s.Length-1].ToString()));


        for(int i=s.Length-2; i>=0;i--)
        {
            newnode.next = new ListNode(int.Parse(s[i].ToString()));
            newnode = newnode.next;
        }

        return dummy.next;
        

    }
}
