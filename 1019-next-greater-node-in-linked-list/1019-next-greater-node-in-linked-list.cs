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
    
    public ListNode reverse(ListNode head){
        ListNode prev = null;
        ListNode curr = head;
        while(curr != null){
            ListNode next = curr.next;
            curr.next = prev;
            prev = curr;
            curr = next;
        }
        return prev;
        
    }
    public int[] NextLargerNodes(ListNode head) {
        head = reverse(head);                       //O(n)
        Stack<int> stack = new Stack<int>();
        List<int> ans = new List<int>();
        
        ListNode curr = head;
        
        while(curr != null){                        //O(n)
            while(stack.Count > 0 && stack.Peek() <= curr.val){
                stack.Pop();
            }
            if(stack.Count > 0){
                ans.Add(stack.Peek());
            }else{
                ans.Add(0);
            }
            stack.Push(curr.val);
            curr = curr.next;
        }
        
        ans.Reverse();                              //O(n)
        
        return ans.ToArray();
        
        /*
            TC = O(n)
            SC = O(n)
        */
    }
}