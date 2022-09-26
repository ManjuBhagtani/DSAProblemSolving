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
    
    int sum = 0;
    
    public void Inorder(TreeNode root){
        if(root == null){
            return;
        }
        Inorder(root.right);
        root.val += sum;
        sum = root.val;
        Inorder(root.left);
    }
    public TreeNode ConvertBST(TreeNode root) {
        Inorder(root);
        return root;
    }
}

/*
    TC = O(n)
    SC = O(h)
*/