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
        //ListNode a = headA;
        //ListNode b = headB;
        
        //while(a != b){
        //   a = a == null ? headB : a.next;
        //  b = b == null ? headA : b.next;
        //}
        
        //return a; //or b
        
        /*
            TC = O(list1 length + list2 length)
            SC = O(1)
        */
        
        //Approach 3
        int n = 0;
        ListNode t1 = headA;
        while(t1 != null){
            n++;
            t1 = t1.next;
        }
        
        int m = 0;
        ListNode t2 = headB;
        while(t2 != null){
            m++;
            t2 = t2.next;
        }
        
        int diff = Math.Abs(n-m);
        
        //assume m is greater
        t1 = headB;
        t2 = headA;
        if(n > m){ //n is greater
            t1 = headA;
            t2 = headB;
        }
        
        int x = 0;
        while(x < diff){
            x++;
            t1 = t1.next;
        }
        while(t1 != t2){
            t1 = t1.next;
            t2 = t2.next;
        }
        
        if(t1 == null || t2 == null){
            return null;
        }
        return t1;
        
    }
}

