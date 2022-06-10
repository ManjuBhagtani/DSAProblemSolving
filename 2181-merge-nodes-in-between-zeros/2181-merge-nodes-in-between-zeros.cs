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
    public ListNode MergeNodes(ListNode head) {
        ListNode t1 = head;
        ListNode t2 = head.next;

        int sum = 0;
        
        while(t2 != null){
            sum += t2.val;
            t2 = t2.next;
            if(t2.val == 0){
                t2.val = sum;
                t1.next = t2;
                t1 = t2;
                t2 = t2.next;
                sum = 0;
            }
        }
        
        return head.next;
        
        /*
            TC = O(N)
            SC = O(1)
        */
    }
}