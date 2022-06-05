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
    public ListNode MergeTwoLists(ListNode list1, ListNode list2) {
        ListNode dummy = new ListNode(-1);
        
        ListNode p1 = list1;
        ListNode p2 = list2;
        ListNode tail = dummy;
        
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
        return dummy.next;
        
        /*
            TC = O(n+m)
            SC = O(1)
        */
    }
}