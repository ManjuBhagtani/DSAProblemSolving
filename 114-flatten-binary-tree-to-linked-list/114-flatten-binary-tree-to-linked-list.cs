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
    public TreeNode combine(TreeNode h1, TreeNode h2){
        if(h1 == null){
            return h2;
        }
        if(h2 == null){
            return h1;
        }
        TreeNode temp = h1;
        
        while(temp.right != null){
            temp = temp.right;
        }
        temp.right = h2;
        return h1;
    }
    
    public TreeNode convert(TreeNode root){
        if(root == null){
            return null;
        } 
        TreeNode h1 = convert(root.left);
        TreeNode h2 = convert(root.right);
        root.left = null;
        root.right = null;
        combine(combine(root, h1), h2);
        return root;
    }
    
    public void Flatten(TreeNode root) {
        if(root == null){
            return;
        }
        TreeNode h1 = convert(root.left);
        TreeNode h2 = convert(root.right);
        root.left = null;
        root.right = null;
        combine(combine(root, h1), h2);
    }
}