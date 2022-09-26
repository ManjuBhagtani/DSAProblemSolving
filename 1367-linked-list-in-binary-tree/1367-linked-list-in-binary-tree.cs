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
/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
 *         this.val = val;
 *         this.left = left;
 *         this.right = right;
 *     }
 * }
 */
public class Solution {
    
    public bool findPath(ListNode head, TreeNode root){ //O(n)
        if(head == null){
            return true;
        }
        if(root == null){
            return false;
        }
        if(head.val == root.val){
            return findPath(head.next, root.left) || findPath(head.next, root.right);
        }
        return false;
    }
    public bool IsSubPath(ListNode head, TreeNode root) { //O(m)
        if(root == null){
            return false;
        }
        if(findPath(head, root)){
            return true;
        }
        return IsSubPath(head, root.left) || IsSubPath(head, root.right);
    }
}

/*
    m = no. of tree nodes, n = length of LL
    TC = O(n*m)
    SC = O(height + n)
*/