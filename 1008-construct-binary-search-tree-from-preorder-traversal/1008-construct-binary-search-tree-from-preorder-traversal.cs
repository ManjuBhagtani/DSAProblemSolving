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
    public TreeNode insertToBST(TreeNode root, int num){
        if(root == null){
            root = new TreeNode(num);
            return root;
        }
        TreeNode temp = root;
        TreeNode parent = null;
        while(temp != null){
            parent = temp;
            if(num < temp.val){
                temp = temp.left;
            }else{
                temp = temp.right;
            }
        }
        if(num < parent.val){
            parent.left = new TreeNode(num);
        }else{
            parent.right = new TreeNode(num);
        }
        return root;
    }
    public TreeNode BstFromPreorder(int[] preorder) {
        int n = preorder.Length;
        
        TreeNode root = null;
        
        for(int i = 0; i<n; i++){
            root = insertToBST(root, preorder[i]);
        }
        
        return root;
    }
}