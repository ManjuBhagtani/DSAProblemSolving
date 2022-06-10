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
    
    public ListNode merge(ListNode head1, ListNode head2){
        ListNode h3 = new ListNode(-1);
        ListNode p1 = head1;
        ListNode p2 = head2;
        ListNode tail = h3;
        while(p1 != null && p2 != null){
            if(p1.val < p2.val){
                tail.next = p1;
                p1 = p1.next;
            }else{
                tail.next = p2;
                p2 = p2.next;
            }
            tail = tail.next;
        }
        while(p1 != null){
            tail.next = p1;
            p1 = p1.next;
            tail = tail.next;
        }
        while(p2 != null){
            tail.next = p2;
            p2 = p2.next;
            tail = tail.next;
        }
        return h3.next;
    }
    
    public ListNode SortList(ListNode head) {
        if(head == null || head.next == null){
            return head;
        }
        ListNode middle = getMiddleNode(head);
        ListNode head2 = middle.next;
        middle.next = null;
        head = SortList(head);
        head2 = SortList(head2);
        return merge(head, head2);
        
        /*
            TC = O(NlogN)
            SC = Height of recursion Tree 
               = O(logN)
        */
    }
}