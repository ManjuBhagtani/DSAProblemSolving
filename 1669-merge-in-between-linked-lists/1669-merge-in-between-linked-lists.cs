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
    public ListNode MergeInBetween(ListNode list1, int a, int b, ListNode list2) {
        ListNode list2Tail = list2;
        while(list2Tail.next != null){
            list2Tail = list2Tail.next;
        }
        
        ListNode t1 = list1;
        int nodesSeen = 1;
        while(nodesSeen < a){
            t1 = t1.next;
            nodesSeen++;
        }
        
        ListNode ptr1 = t1;
        
        while(nodesSeen <= b){
            t1 = t1.next;
            nodesSeen++;
        }
        
        ptr1.next = list2;
        list2Tail.next = t1.next;
        
        return list1;
        
        /*
            n = list1 length, m = list2 length
            TC = O(n+m)
            SC = O(1)
        */
    }
}