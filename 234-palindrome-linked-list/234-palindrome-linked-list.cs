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
    public ListNode getMiddleNode(ListNode head){ //O(N)
        ListNode slow = head;
        ListNode fast = head;
        while(fast.next != null && fast.next.next != null){
            slow = slow.next;
            fast = fast.next.next;
        }
        return slow;
    }
    
    public ListNode reverse(ListNode head){ //O(N)
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
    
    public bool compare(ListNode head1, ListNode head2){ //O(N)
        ListNode t1 = head1;
        ListNode t2 = head2;
        
        while(t2 != null){
            if(t1.val != t2.val){
                return false;
            }
            t1 = t1.next;
            t2 = t2.next;
        }
        return true;
    }
    
    public bool IsPalindrome(ListNode head) {
        ListNode middle = getMiddleNode(head);
        ListNode head2 = middle.next;
        middle.next = null;
        head2 = reverse(head2);
        
        return compare(head, head2);
        
        /*
            TC = O(N)
            SC = O(1)
        */
    }
}