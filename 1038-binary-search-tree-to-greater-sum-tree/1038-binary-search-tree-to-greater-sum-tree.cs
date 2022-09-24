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
    
    public void BstToGstHelper(TreeNode root){
        if(root == null){
            return;
        }
        BstToGstHelper(root.right);
        root.val += sum;
        sum = root.val;
        BstToGstHelper(root.left);
    }
    public TreeNode BstToGst(TreeNode root) {
        BstToGstHelper(root);
        
        return root;
    }
}

/*
    TC = O(n)
    SC = O(h)
*/