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
    public void insert(TreeNode root, int k){
        if(k < root.val){
            if(root.left == null){
                root.left = new TreeNode(k);
                return;
            }else{
                insert(root.left, k);
            }  
        }else{
            if(root.right == null){
                root.right = new TreeNode(k);
                return;
            }else{
                insert(root.right, k);
            }
        }
    }
    
    public TreeNode InsertIntoBST(TreeNode root, int val) {
        TreeNode newNode = new TreeNode(val);
        if(root == null){
            root = newNode;
            return root;
        }
        insert(root, val);
        return root;
    }
}

/*
    TC = O(height) -> can be as bad as O(n) if tree is skewed
    SC = O(1)
*/