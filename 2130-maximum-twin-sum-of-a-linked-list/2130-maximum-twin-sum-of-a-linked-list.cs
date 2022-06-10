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
    public ListNode getMiddleNode(ListNode head){
        ListNode slow = head;
        ListNode fast = head;
        while(fast.next != null && fast.next.next != null){
            slow = slow.next;
            fast = fast.next.next;
        }
        return slow;
    }
    
    public ListNode reverse(ListNode head){
        ListNode prev = null;
        ListNode curr = head;
        while(curr != null){
            ListNode next = curr.next;
            curr.next = prev;
            prev = curr;
            curr = next;
        }
        return prev;
    }
    
    public int findMax(ListNode head1, ListNode head2){
        ListNode t1 = head1;
        ListNode t2 = head2;
        int maxSum = 0;
        while(t1 != null){
            maxSum = Math.Max(maxSum, t1.val + t2.val);
            t1 = t1.next;
            t2 = t2.next;
        }
        
        return maxSum;
    }
    
    public int PairSum(ListNode head) {
        ListNode middle = getMiddleNode(head); //O(n)
        ListNode head2 = middle.next;
        middle.next = null;
        head2 = reverse(head2); //O(n)
        return findMax(head, head2); //O(n)
        
        /*
            TC = O(n)
            SC = O(1)
        */
    }
}
