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
    public ListNode AddTwoNumbers(ListNode l1, ListNode l2) {
        ListNode ans = null;
        int carry = 0;
        
        ListNode temp1 = l1;
        ListNode temp2 = l2;
        ListNode temp3 = ans;
        while(temp1 != null || temp2 != null || carry > 0){
            int sum = carry;
            if(temp1 != null){
                sum += temp1.val;
                temp1 = temp1.next;
            }
            if(temp2 != null){
                sum += temp2.val;
                temp2 = temp2.next;
            }
            ListNode newNode = new ListNode(sum%10);
            carry = sum/10;
            if(temp3 != null){
                temp3.next = newNode;
                temp3 = temp3.next;
            }else{
                temp3 = newNode;
                ans = temp3;
            }         
        }
        
        return ans;
        
        /*
            TC = O(Max(list1.Length, list2.Length))
            SC = O(Max(list1.Length, list2.Length))
        */
    }
}
