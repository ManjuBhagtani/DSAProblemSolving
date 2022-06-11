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
    public ListNode OddEvenList(ListNode head) {
        if(head == null || head.next == null){
            return head;
        }
        
        ListNode x = head;
        ListNode y = head.next; 
        ListNode evenHead = y;
        
        while(y != null && y.next != null){
            x.next = y.next;
            if(y.next != null){
                y.next = y.next.next;
                y = y.next;
            }
            x = x.next;
        }
    
        x.next = evenHead;
    
        return head;
        
        /*
            TC = O(n)
            SC = O(1)
        */
    }
}