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
    public ListNode ReverseList(ListNode head) {
        if(head == null){
            return head;
        }
        if(head.next == null){
            return head;
        }
        
        ListNode p1 = head.next;
        ListNode p2 = p1.next;
        
        int count = 0;
        
        while(p2 != null){
            p1.next = head;
            count++;
            if(count == 1){
                head.next = null;
            }
            
            head = p1;
            p1 = p2;
            p2 = p2.next;
        }
        
        p1.next = head;    
        if(count == 0){
            head.next = null;
        }
        head = p1;
        
        return head;
    }
}