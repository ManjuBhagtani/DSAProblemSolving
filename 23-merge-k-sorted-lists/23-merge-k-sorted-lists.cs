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
    public ListNode merge(ListNode h1, ListNode h2){
        ListNode dummy = new ListNode(-1);
        ListNode p1 = h1;
        ListNode p2 = h2;
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
        ListNode head = dummy.next;
        dummy = null;
        return head;
    }
    public ListNode MergeKLists(ListNode[] lists) {
        int n = lists.Length;

        ListNode m = null;
        
        if(n > 0){
            m = lists[0];
        }
        for(int i = 1; i < n; i++){
            m = merge(m, lists[i]);
        }

        return m;
        
        /*
            n = no. of nodes in each list
            k = no. of such lists
            TC = O(nk)
            SC = O(1)
        */
    }
}