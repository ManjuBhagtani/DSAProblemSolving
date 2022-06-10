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
    public ListNode SwapNodes(ListNode head, int k) {
        ListNode t = head;
        int nodesSeen = 1;
        ListNode ptr1 = head;
        while(t.next != null){
            t = t.next;
            nodesSeen++;
            if(nodesSeen == k){
                ptr1 = t;
            }
        }
        //now nodesSeen holds the total no. of nodes in list
        k = nodesSeen-k+1;
        
        nodesSeen = 1;
        t = head;
        while(nodesSeen < k){
            t = t.next;
            nodesSeen++;
        }
        
        //swapping values
        int temp = t.val;
        t.val = ptr1.val;
        ptr1.val = temp;
        
        return head;
        
        /*
            TC = O(N)
            SC = O(1)
        */
    }
}