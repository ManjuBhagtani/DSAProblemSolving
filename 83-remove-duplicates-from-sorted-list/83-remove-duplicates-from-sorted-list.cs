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
    public ListNode DeleteDuplicates(ListNode head) {
        ListNode temp = head;
        
        while(temp != null){
            if(temp.next != null){
                if(temp.val == temp.next.val){
                    temp.next = temp.next.next;                   
                }else{
                    temp = temp.next;
                }
            }else{
                temp = temp.next;
            }
            
        }
        
        return head;
    }
}