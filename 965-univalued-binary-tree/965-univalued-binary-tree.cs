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
    int value = 0;
    
    public bool IsUnivalTree(TreeNode root, int val){
        if(root == null){
            return true;
        }
        if(root.val == val && IsUnivalTree(root.left, val) && IsUnivalTree(root.right, val)){
            return true;
        }else{
            return false;
        }
        
    }
    
    public bool IsUnivalTree(TreeNode root) {
        if(root == null){
            return true;
        }
        value = root.val;
        return IsUnivalTree(root.left, value) && IsUnivalTree(root.right, value);
    }
}

/*
    TC = O(n)
    SC = O(h)
*/