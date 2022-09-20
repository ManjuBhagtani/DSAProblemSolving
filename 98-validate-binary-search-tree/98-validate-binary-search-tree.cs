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

    public bool isValid(TreeNode root, long min, long max){
        if(root == null){
            return true;
        }
        if((long)root.val < min || (long)root.val > max){
            return false;
        }
        return isValid(root.left, min, (long)root.val-1) && isValid(root.right, (long)root.val+1, max);
    }
    
    public bool IsValidBST(TreeNode root) {
        return isValid(root, long.MinValue, long.MaxValue);
    }
}

/*
    TC = O(n)
    SC = O(h)
*/