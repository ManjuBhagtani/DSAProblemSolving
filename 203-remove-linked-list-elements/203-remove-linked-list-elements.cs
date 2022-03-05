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
    public ListNode RemoveElements(ListNode head, int val) {
        ListNode prev = null;
        ListNode curr = head;
        
        while(curr != null){
            if(curr.val == val){
                if(prev != null){
                    prev.next = curr.next;
                }else{
                    head = curr.next;
                }
                curr = curr.next;
            }else{
                prev = curr;
                curr = curr.next;
            }
        }
        
        return head;
        
        /*
            TC = O(N)
            SC = O(1)
        */
    }
}
