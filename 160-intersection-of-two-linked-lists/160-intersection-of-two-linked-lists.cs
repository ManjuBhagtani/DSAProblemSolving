/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) { val = x; }
 * }
 */
public class Solution {
    public ListNode GetIntersectionNode(ListNode headA, ListNode headB) {
        //Approach 1 - Using Hashset
        // ListNode temp1 = headA;
        
        // HashSet<ListNode> hs = new HashSet<ListNode>();
        
        // while(temp1 != null){
        //     hs.Add(temp1);
        //     temp1 = temp1.next;
        // }
        
        // ListNode temp2 = headB;
        
        // while(temp2 != null){
        //     if(hs.Contains(temp2)){
        //         return temp2;
        //     }
        //     temp2 = temp2.next;
        // }
        
        // return null;
        
        /*
            TC = O(list1 length + list2 length)
            SC = O(list1 length)
        */
        
        //Approach 2
        ListNode a = headA;
        ListNode b = headB;
        
        while(a != b){
            a = a == null ? headB : a.next;
            b = b == null ? headA : b.next;
        }
        
        return a; //or b
        
        /*
            TC = O(list1 length + list2 length)
            SC = O(1)
        */
    }
}

